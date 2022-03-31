using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PraticiensService
    {
        private static PraticiensService instance;
        private static JL_gsbE5Entities unService;

        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static PraticiensService getInstance()
        {
            if (PraticiensService.instance == null)
            {
                PraticiensService.instance = new PraticiensService();
                // on définit un contexte commun à toutes les requêtes
                unService = new JL_gsbE5Entities();
            }
            return PraticiensService.instance;
        }

        // Le constructeur devient privé
        private PraticiensService()
        { }

        public DataTable GetPraticiens()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Prenom", typeof(String));
            dt.Columns.Add("Nom", typeof(String));
            dt.Columns.Add("Type", typeof(String));
            dt.Columns.Add("Adresse", typeof(String));
            dt.Columns.Add("Specialite", typeof(String));

            try
            {
                var req = (from p in unService.praticien
                           join po in unService.posseder on p.id_praticien equals po.id_praticien 
                           join sp in unService.specialite on po.id_specialite equals sp.id_specialite
                           join t in unService.type_praticien on p.id_type_praticien equals t.id_type_praticien
                              select new { p.prenom_praticien, p.nom_praticien, p.adresse_praticien, sp.lib_specialite, t.lib_type_praticien});

                foreach(var res in req)
                {
                    dt.Rows.Add(res.prenom_praticien, res.nom_praticien, res.lib_type_praticien, res.adresse_praticien, res.lib_specialite);
                }
                return dt;
                
            }
            catch { throw; }
        }
    }
}
