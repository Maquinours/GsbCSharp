using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ConnectionService
    {
        private static ConnectionService instance;
        private static JL_gsbE5Entities unService;
        private visiteur unVisiteur;

        public visiteur UnVisiteur { get => unVisiteur; set => unVisiteur = value; }

        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static ConnectionService getInstance()
        {
            if (ConnectionService.instance == null)
            {
                ConnectionService.instance = new ConnectionService();
                // on définit un contexte commun à toutes les requêtes
                unService = new JL_gsbE5Entities();
            }
            return ConnectionService.instance;
        }

        // Le constructeur devient privé
        private ConnectionService()
        { }

        public visiteur RechercheUnVisiteur(String login)
        {
            visiteur unVisiteur;
            try
            {
                unVisiteur = (from v in unService.visiteur
                              where v.login_visiteur == login
                              select v).FirstOrDefault();
                return unVisiteur;
            }
            catch{ throw; }
        }
    }
}
