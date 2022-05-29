﻿using Domain;
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
            if (e.KeyData == (Keys.Control | Keys.F))
            {
                SearchForm search = new SearchForm();
                if (search.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewRow dgvr in dgv_praticiens.Rows)
                    {
                        if (dgvr.Cells[cln_nom.Index].Value.ToString().ToLower().Contains(search.SearchText.ToLower()))
                        {
                            dgvr.Visible = true;
                        }
                        else
                            dgvr.Visible = false;
                    }
                }
            }

            if (e.KeyData == (Keys.Control | Keys.D))
            {
                this.Hide();
                Login();
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
