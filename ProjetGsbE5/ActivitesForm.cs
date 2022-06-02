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
        #region Propriétés
        private long _idPraticien;
        private string _praticienName;
        #endregion

        #region Constructeurs
        public ActivitesForm(long idPraticien, string praticienFirstName, string praticienLastName)
        {
            _idPraticien = idPraticien;
            this._praticienName = $"{praticienFirstName} {praticienLastName}";
            InitializeComponent();

            this.Text = $"Activités de {_praticienName}";
            LoadActivites();
        }
        #endregion

        #region Méthodes privées
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
            catch 
            {
                MessageBox.Show("Erreur lors du chargement des activités", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region Méthodes évènementielles
        private void bt_ajouter_activite_Click(object sender, EventArgs e)
        {
            AjouterModifierActiviteForm form = new AjouterModifierActiviteForm(_idPraticien);

            try
            {
                switch (form.ShowDialog())
                {
                    case DialogResult.OK:
                        {
                            LoadActivites();
                            break;
                        }
                }
            } catch { }
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

            try
            {
                switch (form.ShowDialog())
                {
                    case DialogResult.OK:
                        {
                            LoadActivites();
                            break;
                        }
                }
            } catch { }
        }

        private void bt_supprimer_activite_Click(object sender, EventArgs e)
        {
            if (dgv_activite.SelectedRows.Count == 0) return;

            DataGridViewCellCollection dgvcc = dgv_activite.SelectedRows[0].Cells;
            switch (
                MessageBox.Show($"Souhaitez-vous vraiment supprimer l'activité sélectionnée des activités de {_praticienName} ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            DbDialog.DeleteInviter(
                                _idPraticien,
                                (long)dgvcc[cln_id.Index].Value
                                );
                            LoadActivites();
                        } catch
                        {
                            MessageBox.Show("Erreur lors de la suppression de l'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
            }
        }

        private void dgv_activite_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_activite.CurrentCell != null)
            {
                bt_modifier_activite.Enabled = true;
                bt_supprimer_activite.Enabled = true;
            }
        }
        #endregion
    }
}
