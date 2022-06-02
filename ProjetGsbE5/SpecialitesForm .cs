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
    public partial class SpecialitesForm : Form
    {
        #region Propriétés
        private long _idPraticien;
        private string _praticienName;
        #endregion

        #region Constructeurs
        public SpecialitesForm(long praticienId, string praticienFirstName, string praticienLastName)
        {
            this._idPraticien = praticienId;
            this._praticienName = $"{praticienFirstName} {praticienLastName}";
            InitializeComponent();

            this.Text = $"Spécialités de {_praticienName}";
            LoadSpecialites();
        }
        #endregion

        #region Méthodes privées
        private void LoadSpecialites()
        {
            try
            {
                dgv_specialite.Rows.Clear();
                foreach (DataRow dr in DbDialog.GetSpecialitesPraticien(this._idPraticien).Rows)
                {
                    dgv_specialite.Rows.Add(dr["id_specialite"], dr["lib_specialite"], dr["diplome"], dr["coef_prescription"]);
                }
            } catch 
            {
                MessageBox.Show("Erreur lors du chargement des spécialités", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region Méthodes évènementielles
        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            AjouterModifierSpecialiteForm form = new AjouterModifierSpecialiteForm(this._idPraticien);

            try
            {
                switch (form.ShowDialog())
                {
                    case DialogResult.OK:
                        {
                            LoadSpecialites();
                            break;
                        }
                }
            } catch { }
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            if(dgv_specialite.SelectedRows.Count == 0) return;

            DataGridViewCellCollection dgvcc = dgv_specialite.SelectedRows[0].Cells;
            AjouterModifierSpecialiteForm form = new AjouterModifierSpecialiteForm(
                this._idPraticien,
                (long)dgvcc[cln_idspecialite.Index].Value,
                (string)dgvcc[cln_libspecialite.Index].Value,
                (string)dgvcc[cln_diplome.Index].Value,
                dgvcc[cln_coefprescription.Index].Value.ToString()
                );

            try
            {
                switch (form.ShowDialog())
                {
                    case DialogResult.OK:
                        {
                            LoadSpecialites();
                            break;
                        }
                }
            } catch { }
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            if(dgv_specialite.SelectedRows.Count == 0) return;

            DataGridViewCellCollection dgvcc = dgv_specialite.SelectedRows[0].Cells;
            switch (
                MessageBox.Show($"Souhaitez-vous vraiment supprimer la spécialité \"{dgvcc[cln_libspecialite.Index].Value}\" à {_praticienName} ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            DbDialog.DeletePosseder(_idPraticien, (long)dgvcc[cln_idspecialite.Index].Value);
                            LoadSpecialites();
                        } catch
                        {
                            MessageBox.Show("Erreur lors de la suppression de la spécialité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
            }
        }

        private void dgv_specialite_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dgv_specialite.CurrentCell != null)
            {
                bt_modifier.Enabled = true;
                bt_supprimer.Enabled = true;
            }
        }
        #endregion
    }
}
