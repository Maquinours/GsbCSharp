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
    }

    public partial class SearchForm : Form
    {
        #region Propriétés
        private Dictionary<string, long> _specialites = new Dictionary<string, long>();
        #endregion

        #region Accesseurs
        public string SearchNom { get => tb_nom.Text; }
        public long SearchSpecialite { get => _specialites[cb_specialites.SelectedItem.ToString()]; }
        public SearchType SearchType { get => GetSearchType(); }
        #endregion

        #region Constructeurs
        public SearchForm()
        {
            InitializeComponent();
            LoadSpecialites();
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

        private SearchType GetSearchType()
        {
            if(tc_search.SelectedTab == tp_nom)
                return SearchType.Nom;
            return SearchType.Specialite;
        }
        #endregion

        private void tb_nom_TextChanged(object sender, EventArgs e)
        {
            if(tb_nom.Text.Length == 0)
                bt_valider_search.Enabled = false;
            else
                bt_valider_search.Enabled = true;
        }

        private void cb_specialites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_specialites.SelectedIndex == -1)
                bt_valider_search.Enabled = false;
            else
                bt_valider_search.Enabled = true;
        }

        private void tc_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tc_search.SelectedTab == tp_nom && tb_nom.Text.Length > 0) ||
                (tc_search.SelectedTab == tp_sp && cb_specialites.SelectedIndex != -1))
                bt_valider_search.Enabled = true;
            else
                bt_valider_search.Enabled = false;
        }
    }
}
