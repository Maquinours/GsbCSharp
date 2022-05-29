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
        private Dictionary<string, long> _specialites = new Dictionary<string, long>();

        public SearchForm()
        {
            InitializeComponent();
            LoadSpecialites();
        }

        private void LoadSpecialites()
        {
            DataTable specialites = DbDialog.GetSpecialites();
            foreach (DataRow dr in specialites.Rows)
            {
                cb_specialites.Items.Add(dr["libelle"].ToString());
                _specialites.Add(dr["libelle"].ToString(), (long)dr["id"]);
            }
        }

        public string SearchNom { get => tb_nom.Text; }

        public long SearchSpecialite { get => _specialites[cb_specialites.SelectedItem.ToString()]; }

        public SearchType SearchType { get => GetSearchType(); }

        private SearchType GetSearchType()
        {
            if(tc_search.SelectedTab == tp_nom)
                return SearchType.Nom;
            return SearchType.Specialite;
        }

    }
}
