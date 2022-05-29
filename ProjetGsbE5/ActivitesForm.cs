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
    public partial class ActivitesForm : Form
    {
        private long _idPraticien;
        public ActivitesForm(long idPraticien, string praticienFirstName, string praticienLastName)
        {
            _idPraticien = idPraticien;
            InitializeComponent();

            lb_activite.Text += $"{praticienFirstName} {praticienLastName}";
            LoadActivites();
        }

        private void LoadActivites()
        {
            try
            {
                dgv_activite.Rows.Clear();
                foreach (DataRow dr in DbDialog.GetActivitesPraticien(this._idPraticien).Rows)
                {
                    dgv_activite.Rows.Add(dr["id_activite_compl"], dr["date_activite"], dr["lieu_activite"], dr["theme_activite"], dr["motif_activite"], dr["specialiste"]);
                }
            }
            catch { throw; }
        }

        private void bt_ajouter_activite_Click(object sender, EventArgs e)
        {
            AjouterModifierActiviteForm form = new AjouterModifierActiviteForm(_idPraticien);

            switch(form.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        LoadActivites();
                        break;
                    }
            }
        }

        private void bt_modifier_activite_Click(object sender, EventArgs e)
        {
            if (dgv_activite.SelectedRows.Count == 0) return;

            DataGridViewCellCollection dgvcc = dgv_activite.SelectedRows[0].Cells;
            AjouterModifierActiviteForm form = new AjouterModifierActiviteForm(
                _idPraticien,
                (long)dgvcc[cln_id.Index].Value,
                dgvcc[cln_date.Index].Value.ToString(),
                dgvcc[cln_lieu.Index].Value.ToString(),
                dgvcc[cln_theme.Index].Value.ToString(),
                dgvcc[cln_motif.Index].Value.ToString(),
                char.Parse(dgvcc[cln_specialiste.Index].Value.ToString())
                );

            switch (form.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        LoadActivites();
                        break;
                    }
            }
        }

        private void bt_supprimer_activite_Click(object sender, EventArgs e)
        {
            if (dgv_activite.SelectedRows.Count == 0) return;

            DataGridViewCellCollection dgvcc = dgv_activite.SelectedRows[0].Cells;
            switch (
                MessageBox.Show($"Souhaitez-vous vraiment supprimer l'activité sélectionné des {lb_activite.Text} ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    {
                        DbDialog.DeleteInviter(
                            _idPraticien,
                            (long)dgvcc[cln_id.Index].Value
                            );
                        LoadActivites();
                        break;
                    }
            }
        }
    }
}
