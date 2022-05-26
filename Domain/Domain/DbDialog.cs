using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Domain
{
    public static class DbDialog
    {
        private static MySqlConnection _conn = new MySqlConnection($"Server=localhost;Database=gsb;port=3306;User Id=usersio;password=sio");

        /// <summary>
        /// Obtenir le mot de passe et le sel d'un visiteur
        /// </summary>
        /// <param name="login">Login du visiteur à chercher</param>
        /// <returns>mot de passe et sel d'un visiteur</returns>
        public static DataTable GetVisiteur(string login)
        {
            DbDialog._conn.Open();

            DataTable dt = new DataTable();

            DataColumn[] cols =
            {
                new DataColumn("pwd", typeof(string)),
                new DataColumn("pwd_salt", typeof(string))
            };

            dt.Columns.AddRange(cols);

            string sql = "SELECT pwd_visiteur_sha256, sha_256_salt FROM visiteur WHERE login_visiteur = @login";

            MySqlCommand cmd = new MySqlCommand(sql, DbDialog._conn);
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) throw new Exception("Aucun résultat");
                reader.Read();

                dt.Rows.Add(reader.GetString(reader.GetOrdinal("pwd_visiteur_sha256")), reader.GetString(reader.GetOrdinal("sha_256_salt")));

                reader.Close();
                DbDialog._conn.Close();
                return dt;
            }
            catch
            {
                DbDialog._conn.Close();
                throw;
            }
        }

        /// <summary>
        /// Obtenir les informations de chaque praticien
        /// </summary>
        /// <returns>informations de chaque visi</returns>
        public static DataTable GetPraticiens()
        {
            DbDialog._conn.Open();
            DataTable dt = new DataTable();

            DataColumn[] cols =
            {
                new DataColumn("id", typeof(long)),
                new DataColumn("nom", typeof (string)),
                new DataColumn("prenom", typeof(string)),
                new DataColumn("type", typeof(long)),
                new DataColumn("adresse", typeof(string))
            };

            dt.Columns.AddRange(cols);

            string sql = "SELECT * FROM praticien";

            MySqlCommand cmd = new MySqlCommand(sql, DbDialog._conn);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows) throw new Exception("Aucun résultat");
                while (reader.Read())
                {
                    dt.Rows.Add(
                        reader.GetInt64(reader.GetOrdinal("id_praticien")),
                        reader.GetString(reader.GetOrdinal("nom_praticien")),
                        reader.GetString(reader.GetOrdinal("prenom_praticien")),
                        reader.GetInt64(reader.GetOrdinal("id_type_praticien")),
                        reader.GetString(reader.GetOrdinal("adresse_praticien")) + ", " + reader.GetString(reader.GetOrdinal("cp_praticien")) + " " + reader.GetString(reader.GetOrdinal("ville_praticien"))
                        );
                }
                DbDialog._conn.Close();
                return dt;
            }
            catch
            {
                DbDialog._conn.Close();
                throw;
            }
        }

        public static Dictionary<long, string> GetTypesPraticiens()
        {
            Dictionary<long, string> ret = new Dictionary<long, string>();

            DbDialog._conn.Open();

            string sql = "SELECT id_type_praticien, lib_type_praticien FROM type_praticien";

            MySqlCommand cmd = new MySqlCommand(sql, DbDialog._conn);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows) throw new Exception("Aucun résultat");
                while (reader.Read())
                {
                    ret.Add(reader.GetInt64(reader.GetOrdinal("id_type_praticien")), reader.GetString(reader.GetOrdinal("lib_type_praticien")));
                }
                DbDialog._conn.Close();
                return ret;
            }
            catch
            {
                DbDialog._conn.Close();
                throw;
            }
        }
    }
}