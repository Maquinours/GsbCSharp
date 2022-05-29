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
        private long _idPraticien;
        public SpecialitesForm(long praticienId, string praticienFirstName, string praticienLastName)
        {
            this._idPraticien = praticienId;
            InitializeComponent();

            lb_specialite.Text += $"{praticienFirstName} {praticienLastName}";
            LoadSpecialites();
        }

        private void LoadSpecialites()
        {
            try
            {
                dgv_specialite.Rows.Clear();
                foreach (DataRow dr in DbDialog.GetSpecialitesPraticien(this._idPraticien).Rows)
                {
                    dgv_specialite.Rows.Add(dr["id_specialite"], dr["lib_specialite"], dr["diplome"], dr["coef_prescription"]);
                }
            } catch { throw; }
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            AjouterModifierSpecialiteForm form = new AjouterModifierSpecialiteForm(this._idPraticien);

            switch(form.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        LoadSpecialites();
                        break;
                    }
            }
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

            switch(form.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        LoadSpecialites();
                        break;
                    }
            }
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            if(dgv_specialite.SelectedRows.Count == 0) return;

            DataGridViewCellCollection dgvcc = dgv_specialite.SelectedRows[0].Cells;
            switch (
                MessageBox.Show($"Souhaitez-vous vraiment supprimer la spécialité \"{dgvcc[cln_libspecialite.Index].Value}\" des {lb_specialite.Text} ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    {
                        DbDialog.DeletePosseder(_idPraticien, (long)dgvcc[cln_idspecialite.Index].Value);
                        LoadSpecialites();
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
    }
}
