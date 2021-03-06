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
    public partial class AjouterModifierSpecialiteForm : Form
    {
        #region Propriétés
        private long _idPraticien;
        private long _idSpecialite;
        private Dictionary<string, long> _specialites = new Dictionary<string, long>();
        #endregion

        #region Constructeurs
        public AjouterModifierSpecialiteForm(long idPraticien)
        {
            _idPraticien = idPraticien;
            _idSpecialite = -1;
            InitializeComponent();
            this.Text = "Ajout d'une spécialité";
            LoadAvailablesSpecialites();
        }

        public AjouterModifierSpecialiteForm(long idPraticien, long idSpecialite, string libSpecialite, string diplome, string coefPrescription)
        {
            _idPraticien = idPraticien;
            _idSpecialite = idSpecialite;
            InitializeComponent();
            this.Text = "Modification d'une spécialité";
            cb_libelle.Items.Add(libSpecialite);
            cb_libelle.SelectedItem = libSpecialite;
            cb_libelle.Enabled = false;
            tb_diplome.Text = diplome;
            tb_coef.Text = coefPrescription;
        }
        #endregion

        #region Méthodes privées
        private void LoadAvailablesSpecialites()
        {
            try
            {
                DataTable specialites = DbDialog.GetSpecialitesAvailables(this._idPraticien);
                foreach (DataRow specialite in specialites.Rows)
                {
                    cb_libelle.Items.Add(specialite["libelle"]);
                    _specialites.Add((string)specialite["libelle"], (long)specialite["id"]);
                }
            } catch
            {
                MessageBox.Show("Erreur lors du chargement des spécialités disponibles", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region Méthodes évènementielles
        private void bt_valider_sp_Click(object sender, EventArgs e)
        {
            // Check values
            if(cb_libelle.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner une spécialité", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (tb_diplome.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner un diplome", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (tb_coef.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner un coef de prescription", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Insert or update
            if (_idSpecialite == -1)
            {
                try
                {
                    DbDialog.InsertPosseder(_idPraticien, _specialites[cb_libelle.Text], tb_diplome.Text, Decimal.Parse(tb_coef.Text));
                } catch
                {
                    MessageBox.Show("Erreur lors de l'ajout de la spécialité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DbDialog.UpdatePosseder(_idPraticien, _idSpecialite, tb_diplome.Text, Decimal.Parse(tb_coef.Text));
                } catch
                {
                    MessageBox.Show("Erreur lors de la modification de la spécialité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void tb_coef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            int dotIndex = tb_coef.Text.IndexOf(',');
            if (e.KeyChar == ',' && dotIndex == -1 && tb_coef.Text.Length != 0) return;
            if (char.IsDigit(e.KeyChar))
            {
                if(dotIndex == -1 && tb_coef.Text.Length < 11) return;
                if (dotIndex != -1 && (tb_coef.Text.Length - dotIndex < 3)) return;
            }
            
            e.Handled = true;
        }

        private void tb_diplome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tb_diplome.Text.Length < 100) return;

            e.Handled = true;
        }
        #endregion
    }
}
