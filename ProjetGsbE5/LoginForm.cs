using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            //visiteur visiteur = ConnectionService.getInstance().RechercheUnVisiteur(tb_login.Text);

            //if (visiteur != null && visiteur.pwd_visiteur.Equals(tb_pwd.Text))
            //    this.DialogResult = DialogResult.OK;
            //else
            //    MessageBox.Show("Erreur d'authentification", "Login ou mot de passe incorrect");

            if(tb_login.Text == "test" && tb_pwd.Text == "test") // Test externe
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Login ou mot de passe incorrect", "Erreur d'authentification");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Souhaitez-vous vraiment quitter le programme ?", "Quitter le programme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
