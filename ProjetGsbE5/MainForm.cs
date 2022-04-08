using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

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
        }

        #region Méthodes évènementielles 
        private void tab_control_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tab_praticiens)
            {
                DataTable praticiens = PraticiensService.getInstance().GetPraticiens();
                foreach(DataRow dr in praticiens.Rows)
                {
                    dgv_praticiens.Rows.Add(dr["Nom"], dr["Prenom"], dr["Specialite"], dr["Type"], dr["Adresse"]);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(tab_control.SelectedTab == tab_praticiens)
            {
                if (e.KeyData == (Keys.Control | Keys.F))
                {
                    SearchForm search = new SearchForm();
                    if(search.ShowDialog() == DialogResult.OK)
                    {
                        foreach(DataGridViewRow dgvr in dgv_praticiens.Rows)
                        {
                            if (dgvr.Cells[column_nom.Index].Value.ToString().ToLower().Contains(search.SearchText.ToLower())
                                || dgvr.Cells[column_specialite.Index].Value.ToString().ToLower().Contains(search.SearchText.ToLower()))
                            {
                                dgvr.Visible = true;
                            }
                            else
                                dgvr.Visible = false;
                        }
                    }
                }

                if(e.KeyData == (Keys.Control | Keys.D))
                {
                    this.Hide();
                    Login();
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
                    Application.Exit();
                    break;
            }
        }
        #endregion
    }
}
