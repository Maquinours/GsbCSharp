using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjetGsbE5
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Login();
            LoadPraticiens();
        }

        #region Méthodes évènementielles 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.F)) // Rechercher
            {
                SearchForm form = new SearchForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    switch(form.SearchType)
                    {
                        case SearchType.Nom:
                            {
                                string textToSearch = form.SearchNom.ToLower();
                                foreach (DataGridViewRow dgvr in dgv_praticiens.Rows)
                                {
                                    if (dgvr.Cells[cln_nom.Index].Value.ToString().ToLower().Contains(textToSearch))
                                        dgvr.Visible = true;
                                    else
                                        dgvr.Visible = false;
                                }
                                break;
                            }
                           
                            case SearchType.Specialite:
                            {
                                long specialiteToSearch = form.SearchSpecialite;
                                HashSet<long> praticiensToSearch = DbDialog.GetPraticiensBySpecialite(specialiteToSearch);
                                foreach(DataGridViewRow dgvr in dgv_praticiens.Rows)
                                {
                                    if (praticiensToSearch.Contains((long)dgvr.Cells[cln_id.Index].Value))
                                        dgvr.Visible = true;
                                    else
                                        dgvr.Visible = false;
                                }
                                break;
                            }
                    }
                }
            }

            else if (e.KeyData == (Keys.Control | Keys.D)) // Déconnexion
            {
                this.Hide();
                Login();
            }

            else if(e.KeyData == (Keys.Control | Keys.R)) // Raffraichir
            {
                foreach(DataGridViewRow dgvr in dgv_praticiens.Rows)
                {
                    dgvr.Visible = true;
                }
            }

        }
        #endregion

        #region Méthodes privées
        private void Login()
        {
            LoginForm formLogin = new LoginForm();
            DialogResult result = formLogin.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    MessageBox.Show("Connecté");
                    break;
                case DialogResult.Cancel:
                    Environment.Exit(0);
                    break;
            }
        }

        private void LoadPraticiens()
        {
            Dictionary<long, string> praticienTypes = DbDialog.GetTypesPraticiens();
            foreach (DataRow dr in DbDialog.GetPraticiens().Rows)
            {
                dgv_praticiens.Rows.Add(dr["id"], dr["nom"], dr["prenom"], praticienTypes[(long)dr["type"]], dr["adresse"]);
            }
        }
        #endregion

        private void dgv_praticiens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == cln_specialites.Index)
            {
                SpecialitesForm formSpecialites = new SpecialitesForm(
                    (long)dgv_praticiens.Rows[e.RowIndex].Cells[cln_id.Index].Value,
                    (string)dgv_praticiens.Rows[e.RowIndex].Cells[cln_prenom.Index].Value,
                    (string)dgv_praticiens.Rows[e.RowIndex].Cells[cln_nom.Index].Value
                    );
                formSpecialites.ShowDialog();
            }

            else if(e.ColumnIndex == cln_activites.Index)
            {
                ActivitesForm formActivites = new ActivitesForm(
                    (long)dgv_praticiens.Rows[e.RowIndex].Cells[cln_id.Index].Value,
                    dgv_praticiens.Rows[e.RowIndex].Cells[cln_prenom.Index].Value.ToString(),
                    dgv_praticiens.Rows[e.RowIndex].Cells[cln_nom.Index].Value.ToString()
                    );
                formActivites.Show();
            }
        }
    }
}
