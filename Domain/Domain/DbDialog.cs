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
            DataTable dt = new DataTable();
            DataColumn[] cols =
            {
                new DataColumn("pwd", typeof(string)),
                new DataColumn("pwd_salt", typeof(string))
            };
            dt.Columns.AddRange(cols);

            string sql = "SELECT pwd_visiteur_sha256, sha_256_salt FROM visiteur WHERE login_visiteur = @login";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Prepare();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) throw new Exception("Aucun résultat");
                reader.Read();
                dt.Rows.Add(reader.GetString(reader.GetOrdinal("pwd_visiteur_sha256")), reader.GetString(reader.GetOrdinal("sha_256_salt")));

                _conn.Close();
                return dt;
            }
            catch
            {
                _conn.Close();
                throw;
            }
        }

        /// <summary>
        /// Obtenir les informations de chaque praticien
        /// </summary>
        /// <returns>informations de chaque visi</returns>
        public static DataTable GetPraticiens()
        {
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
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
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

                _conn.Close();
                return dt;
            }
            catch
            {
                _conn.Close();
                throw;
            }
        }

        public static Dictionary<long, string> GetTypesPraticiens()
        {
            Dictionary<long, string> ret = new Dictionary<long, string>();

            string sql = "SELECT id_type_praticien, lib_type_praticien FROM type_praticien";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(reader.GetInt64(reader.GetOrdinal("id_type_praticien")), reader.GetString(reader.GetOrdinal("lib_type_praticien")));
                }

                _conn.Close();
                return ret;
            }
            catch
            {
                _conn.Close();
                throw;
            }
        }

        public static DataTable GetSpecialitesPraticien(long idPraticien)
        {
            DataTable dt = new DataTable();
            DataColumn[] cols =
            {
                new DataColumn("id_specialite", typeof(long)),
                new DataColumn("lib_specialite", typeof (string)),
                new DataColumn("diplome", typeof(string)),
                new DataColumn("coef_prescription", typeof(decimal))
            };
            dt.Columns.AddRange(cols);

            string sql = "SELECT * FROM specialite S JOIN posseder P ON S.id_specialite=P.id_specialite WHERE P.id_praticien=@id";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", idPraticien);
            cmd.Prepare();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    dt.Rows.Add(
                        reader.GetInt64(reader.GetOrdinal("id_specialite")),
                        reader.GetString(reader.GetOrdinal("lib_specialite")),
                        reader.GetString(reader.GetOrdinal("diplome")),
                        reader.GetDecimal(reader.GetOrdinal("coef_prescription"))
                        );
                }

                _conn.Close();
                return dt;
            }
            catch 
            {
                _conn.Close();
                throw; 
            }
        }

        public static DataTable GetSpecialitesAvailables(long idPraticien)
        {
            DataTable dt = new DataTable();
            DataColumn[] cols =
            {
                new DataColumn("id", typeof(long)),
                new DataColumn("libelle", typeof(string))
            };
            dt.Columns.AddRange(cols);

            string sql = "SELECT * FROM specialite WHERE id_specialite NOT IN (SELECT id_specialite FROM posseder WHERE id_praticien=@praticien)";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@praticien", idPraticien);
            cmd.Prepare();
            
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    dt.Rows.Add(
                        reader.GetInt64(reader.GetOrdinal("id_specialite")),
                        reader.GetString(reader.GetOrdinal("lib_specialite"))
                        );
                }

                _conn.Close();
                return dt;
            } catch
            {
                _conn.Close();
                throw;
            }
        }

        public static DataTable GetActivitesPraticien(long idPraticien)
        {
            DataTable dt = new DataTable();
            DataColumn[] cols =
            {
                new DataColumn("id_activite_compl", typeof(long)),
                new DataColumn("date_activite", typeof (string)),
                new DataColumn("lieu_activite", typeof(string)),
                new DataColumn("theme_activite", typeof(string)),
                new DataColumn("motif_activite", typeof(string)),
                new DataColumn("specialiste", typeof(char))
            };
            dt.Columns.AddRange(cols);

            string sql = "SELECT * FROM activite_compl A JOIN inviter I ON A.id_activite_compl=I.id_activite_compl WHERE I.id_praticien=@id";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", idPraticien);
            cmd.Prepare();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dt.Rows.Add(
                        reader.GetInt64(reader.GetOrdinal("id_activite_compl")),
                        reader.GetString(reader.GetOrdinal("date_activite")),
                        reader.GetString(reader.GetOrdinal("lieu_activite")),
                        reader.GetString(reader.GetOrdinal("theme_activite")),
                        reader.GetString(reader.GetOrdinal("motif_activite")),
                        reader.GetChar(reader.GetOrdinal("specialiste"))
                        );
                }

                _conn.Close();
                return dt;
            }
            catch
            {
                _conn.Close();
                throw;
            }
        }

        public static DataTable GetActivitesAvailables(long idPraticien)
        {
            DataTable dt = new DataTable();
            DataColumn[] cols =
            {
                new DataColumn("id", typeof(long)),
                new DataColumn("date", typeof(string)),
                new DataColumn("lieu", typeof(string)),
                new DataColumn("theme", typeof(string)),
                new DataColumn("motif",typeof(string))
            };
            dt.Columns.AddRange(cols);

            string sql = "SELECT * FROM activite_compl WHERE id_activite_compl NOT IN (SELECT id_activite_compl FROM inviter WHERE id_praticien=@praticien)";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@praticien", idPraticien);
            cmd.Prepare();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dt.Rows.Add(
                        reader.GetInt64(reader.GetOrdinal("id_activite_compl")),
                        reader.GetString(reader.GetOrdinal("date_activite")),
                        reader.GetString(reader.GetOrdinal("lieu_activite")),
                        reader.GetString(reader.GetOrdinal("theme_activite")),
                        reader.GetString(reader.GetOrdinal("motif_activite"))
                        );
                }

                _conn.Close();
                return dt;
            }
            catch
            {
                _conn.Close();
                throw;
            }
        }

        public static void InsertPosseder(long idPraticien, long idSpecialite, string diplome, decimal coefPrescription)
        {
            string sql = "INSERT INTO posseder(id_praticien, id_specialite, diplome, coef_prescription) "
                + "VALUES(@praticien, @specialite, @diplome, @coef_prescription)";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@praticien", idPraticien);
            cmd.Parameters.AddWithValue("@specialite", idSpecialite);
            cmd.Parameters.AddWithValue("@diplome", diplome);
            cmd.Parameters.AddWithValue("@coef_prescription", coefPrescription);
            cmd.Prepare();

            try
            {
                cmd.ExecuteNonQuery();
                
                _conn.Close();
            } catch 
            {
                _conn.Close();
                throw;
            }
        }

        public static void InsertInviter(long idPraticien, long idActivite, char specialiste)
        {
            string sql = "INSERT INTO inviter(id_praticien, id_activite_compl, specialiste) "
                + "VALUES(@praticien, @activite, @specialiste)";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@praticien", idPraticien);
            cmd.Parameters.AddWithValue("@activite", idActivite);
            cmd.Parameters.AddWithValue("@specialiste", specialiste);
            cmd.Prepare();

            try
            {
                cmd.ExecuteNonQuery();

                _conn.Close();
            } catch
            {
                _conn.Close();
                throw;  
            }
        }

        public static void UpdatePosseder(long idPraticien, long idSpecialite, string diplome, decimal coefPrescription)
        {
            string sql = "UPDATE posseder SET diplome=@diplome, coef_prescription=@coef_prescription WHERE id_praticien=@praticien AND id_specialite=@specialite";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@diplome", diplome);
            cmd.Parameters.AddWithValue("@coef_prescription", coefPrescription);
            cmd.Parameters.AddWithValue("@praticien", idPraticien);
            cmd.Parameters.AddWithValue("@specialite", idSpecialite);
            cmd.Prepare();

            try
            {
                cmd.ExecuteNonQuery();

                _conn.Close();
            } catch 
            {
                _conn.Close();
                throw; 
            }
        }

        public static void UpdateInviter(long idPraticien, long idActivite, char specialiste)
        {
            string sql = "UPDATE inviter SET specialiste=@specialiste WHERE id_praticien=@praticien AND id_activite_compl=@activite";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@specialiste", specialiste);
            cmd.Parameters.AddWithValue("@praticien", idPraticien);
            cmd.Parameters.AddWithValue("@activite", idActivite);
            cmd.Prepare();

            try
            {
                cmd.ExecuteNonQuery();

                _conn.Close();
            }
            catch
            {
                _conn.Close();
                throw;
            }
        }

        public static void DeletePosseder(long idPraticien, long idSpecialite)
        {
            string sql = "DELETE FROM posseder WHERE id_praticien=@praticien AND id_specialite=@specialite";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@praticien", idPraticien);
            cmd.Parameters.AddWithValue("@specialite", idSpecialite);
            cmd.Prepare();

            try
            {
                cmd.ExecuteNonQuery();

                _conn.Close();
            } catch 
            {
                _conn.Close();
                throw; 
            }
        }

        public static void DeleteInviter(long idPraticien, long idActivite)
        {
            string sql = "DELETE FROM inviter WHERE id_praticien=@praticien AND id_activite_compl=@activite";
            _conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@praticien", idPraticien);
            cmd.Parameters.AddWithValue("@activite", idActivite);
            cmd.Prepare();

            try
            {
                cmd.ExecuteNonQuery();

                _conn.Close();
            }
            catch
            {
                _conn.Close();
                throw;
            }
        }
    }
}