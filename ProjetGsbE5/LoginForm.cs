using System;
using System.Data;
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

            try
            {
                DataRow visiteur = DbDialog.GetVisiteur(tb_login.Text).Rows[0];

                Byte[] salt = Hash.transformeEnBytes(visiteur["pwd_salt"].ToString());
                Byte[] tempo = Hash.transformeEnBytes(visiteur["pwd"].ToString());

                if (Hash.VerifyPassword(salt, tb_pwd.Text, tempo))
                    this.DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Login ou mot de passe incorrect", "Erreur d'authentification");
            }
            catch (Exception ex)
            {
                if (ex.Message == "Aucun résultat")
                    MessageBox.Show("Login ou mot de passe incorrect", "Erreur d'authentification");
                else
                    MessageBox.Show("Erreur inconnue", "Erreur d'authentification");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous vraiment quitter le programme ?", "Quitter le programme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DialogResult = DialogResult.Cancel;
        }
    }
}
