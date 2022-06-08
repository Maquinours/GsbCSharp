using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjetGsbE5
{
    public partial class MainForm : Form
    {
        #region Constructeurs
        public MainForm()
        {
            InitializeComponent();
            Login();
            LoadPraticiens();
        }
        #endregion

        #region Méthodes évènementielles
        private void tsmi_deconnexion_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void tsmi_affichertout_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgv_praticiens.Rows)
            {
                dgvr.Visible = true;
            }
            tsmi_affichertout.Enabled = false;
        }

        private void tsmi_rechercher_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            try
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    switch (form.SearchType)
                    {
                        case SearchType.Nom:
                            {
                                string textToSearch = form.SearchNom.ToLower();

                                if (textToSearch.Length == 0) return;

                                foreach (DataGridViewRow dgvr in dgv_praticiens.Rows)
                                {
                                    dgvr.Visible = dgvr.Cells[cln_nom.Index].Value.ToString().ToLower().Contains(textToSearch);
                                }
                                break;
                            }
                        case SearchType.Specialite:
                            {
                                try
                                {
                                    long specialiteToSearch = form.SearchSpecialite;
                                    try
                                    {
                                        HashSet<long> praticiensToSearch = DbDialog.GetPraticiensBySpecialite(specialiteToSearch);
                                        foreach (DataGridViewRow dgvr in dgv_praticiens.Rows)
                                        {
                                            dgvr.Visible = praticiensToSearch.Contains((long)dgvr.Cells[cln_id.Index].Value);
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Erreur lors de la recherche de praticiens", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                } catch { }
                                break;
                            }
                        case SearchType.Type:
                            {
                                string typeToSearch = form.SearchTypePraticien;

                                if (typeToSearch.Length == 0) return;

                                foreach (DataGridViewRow dgvr in dgv_praticiens.Rows)
                                {
                                    dgvr.Visible = dgvr.Cells[cln_type.Index].Value.ToString() == typeToSearch;
                                }
                                break;
                            }
                    }
                    tsmi_affichertout.Enabled = true;
                }
            } catch { }
        }

        private void tsmi_quitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dgv_praticiens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cln_specialites.Index)
            {
                SpecialitesForm formSpecialites = new SpecialitesForm(
                    (long)dgv_praticiens.Rows[e.RowIndex].Cells[cln_id.Index].Value,
                    (string)dgv_praticiens.Rows[e.RowIndex].Cells[cln_prenom.Index].Value,
                    (string)dgv_praticiens.Rows[e.RowIndex].Cells[cln_nom.Index].Value
                    );
                try
                {
                    formSpecialites.ShowDialog();
                } catch { }
            }
            else if (e.ColumnIndex == cln_activites.Index)
            {
                ActivitesForm formActivites = new ActivitesForm(
                    (long)dgv_praticiens.Rows[e.RowIndex].Cells[cln_id.Index].Value,
                    dgv_praticiens.Rows[e.RowIndex].Cells[cln_prenom.Index].Value.ToString(),
                    dgv_praticiens.Rows[e.RowIndex].Cells[cln_nom.Index].Value.ToString()
                    );
                try
                {
                    formActivites.Show();
                } catch { }
            }
        }
        #endregion

        #region Méthodes privées
        /// <summary>
        /// Afficher le formulaire de connexion
        /// </summary>
        private void Login()
        {
            this.Visible = false;
            LoginForm formLogin = new LoginForm();
            DialogResult result = formLogin.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    MessageBox.Show("Connecté");
                    this.Visible = true;
                    break;
                case DialogResult.Cancel:
                    Environment.Exit(0);
                    break;
            }
        }

        /// <summary>
        /// Afficher les praticiens
        /// </summary>
        private void LoadPraticiens()
        {
            try
            {
                Dictionary<long, string> praticienTypes = DbDialog.GetTypesPraticiens();
                foreach (DataRow dr in DbDialog.GetPraticiens().Rows)
                {
                    dgv_praticiens.Rows.Add(dr["id"], dr["nom"], dr["prenom"], praticienTypes[(long)dr["type"]], dr["adresse"]);
                }
            } catch
            {
                MessageBox.Show("Erreur lors du chargement des praticiens", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion
    }
}
