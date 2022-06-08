using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using Domain;

namespace ProjetGsbE5
{
    public enum SearchType
    {
        Nom,
        Specialite,
        Type
    }

    public partial class SearchForm : Form
    {
        #region Propriétés
        private Dictionary<string, long> _specialites = new Dictionary<string, long>();
        #endregion

        #region Accesseurs
        public string SearchNom { get => tb_nom.Text; }
        public long SearchSpecialite { get => _specialites[cb_specialites.SelectedItem.ToString()]; }
        public string SearchTypePraticien { get => cb_types.Text; }
        public SearchType SearchType { get => GetSearchType(); }
        #endregion

        #region Constructeurs
        public SearchForm()
        {
            InitializeComponent();
            LoadSpecialites();
            LoadTypes();
        }
        #endregion

        #region Méthodes privées
        private void LoadSpecialites()
        {
            try
            {
                DataTable specialites = DbDialog.GetSpecialites();
                foreach (DataRow dr in specialites.Rows)
                {
                    cb_specialites.Items.Add(dr["libelle"].ToString());
                    _specialites.Add(dr["libelle"].ToString(), (long)dr["id"]);
                }
            } catch
            {
                MessageBox.Show("Erreur lors du chargement des spécialités", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadTypes()
        {
            try
            {
                Dictionary<long, string> types = DbDialog.GetTypesPraticiens();
                foreach(string type in types.Values)
                {
                    cb_types.Items.Add(type);
                }
            } catch
            {
                MessageBox.Show("Erreur lors du chargement des types", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private SearchType GetSearchType()
        {
            if(tc_search.SelectedTab == tp_nom)
                return SearchType.Nom;
            if(tc_search.SelectedTab == tp_sp)
                return SearchType.Specialite;
            return SearchType.Type;
        }
        #endregion

        private void tb_nom_TextChanged(object sender, EventArgs e)
        {
                bt_valider_search.Enabled = tb_nom.Text.Length != 0;
        }

        private void cb_specialites_SelectedIndexChanged(object sender, EventArgs e)
        {
                bt_valider_search.Enabled = cb_specialites.SelectedIndex != -1;
        }

        private void tc_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_valider_search.Enabled = (tc_search.SelectedTab == tp_nom && tb_nom.Text.Length > 0) ||
                (tc_search.SelectedTab == tp_sp && cb_specialites.SelectedIndex != -1) ||
                (tc_search.SelectedTab == tp_type && cb_types.SelectedIndex != -1);
        }

        private void cb_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_valider_search.Enabled = cb_types.SelectedIndex != -1;
        }
    }
}
