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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tab_control.TabPages.Remove(tab_praticiens);
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tb_login.ResetText();
            tb_pwd.ResetText();
        }

        private void bt_connection_Click(object sender, EventArgs e)
        {
            visiteur visiteur = ConnectionService.getInstance().RechercheUnVisiteur(tb_login.Text);

            if (visiteur != null && visiteur.pwd_visiteur.Equals(tb_pwd.Text))
            {
                MessageBox.Show("Connecté");
                tab_control.TabPages.Add(tab_praticiens);
                tab_control.SelectedTab = tab_praticiens;
                tab_control.TabPages.Remove(tab_connection);
            }
            else
                MessageBox.Show("Erreur d'authentification", "Login ou mot de passe incorrect");
        }

        private void tab_control_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tab_praticiens)
            {
                this.Width = 800;
                this.Height = 600;
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
                    Search search = new Search();
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
            }
        }
    }
}
