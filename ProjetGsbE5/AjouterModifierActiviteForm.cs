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
    public partial class AjouterModifierActiviteForm : Form
    {
        #region Propriétés
        private long _idPraticien;
        private long _idActivite;
        private DataTable _activites;
        #endregion

        #region Constructeurs
        public AjouterModifierActiviteForm(long idPraticien)
        {
            _idPraticien = idPraticien;
            _idActivite = -1;
            try
            {
                _activites = DbDialog.GetActivitesAvailables(idPraticien);

                InitializeComponent();
                this.Text = "Ajout d'une activité";
                LoadDates();
            } catch
            {
                MessageBox.Show("Erreur lors du chargement des activités disponibles", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public AjouterModifierActiviteForm(long idPraticien, long idActivite, string dateActivite, string lieuActivite, string themeActivite, string motifActivite, char specialiste)
        {
            _idPraticien = idPraticien;
            _idActivite = idActivite;
            InitializeComponent();
            this.Text = "Modification d'une activité";
            cb_date.Enabled = false;
            cb_date.Items.Add(dateActivite);
            cb_date.SelectedItem = dateActivite;
            cb_lieu.Items.Add(lieuActivite);
            cb_lieu.SelectedItem = lieuActivite;
            cb_theme.Items.Add(themeActivite);
            cb_theme.SelectedItem = themeActivite;
            cb_motif.Items.Add(motifActivite);
            cb_motif.SelectedItem = motifActivite;
            tb_specialiste.Text = specialiste.ToString();
        }
        #endregion

        #region Méthodes privées
        private void LoadDates()
        {
            cb_date.Items.Clear();

            foreach(DataRow dr in _activites.Rows)
            {
                string date = dr["date"].ToString();
                if(!cb_date.Items.Contains(date))
                    cb_date.Items.Add(date);
            }
        }

        private void LoadLieux()
        {
            cb_lieu.Items.Clear();

            foreach(DataRow dr in _activites.Rows)
            {
                if(dr["date"].ToString() == cb_date.SelectedItem.ToString())
                {
                    string lieu = dr["lieu"].ToString();
                    if (!cb_lieu.Items.Contains(lieu))
                        cb_lieu.Items.Add(lieu);
                }
            }
        }

        private void LoadThemes()
        {
            cb_theme.Items.Clear();

            foreach(DataRow dr in _activites.Rows)
            {
                if(dr["date"].ToString() == cb_date.SelectedItem.ToString() &&
                    dr["lieu"].ToString() == cb_lieu.SelectedItem.ToString())
                {
                    string theme = dr["theme"].ToString();
                    if (!cb_theme.Items.Contains(theme))
                        cb_theme.Items.Add(theme);
                }
            }
        }

        private void LoadMotifs()
        {
            cb_motif.Items.Clear();

            foreach(DataRow dr in _activites.Rows)
            {
                if (dr["date"].ToString() == cb_date.SelectedItem.ToString() &&
                    dr["lieu"].ToString() == cb_lieu.SelectedItem.ToString() &&
                    dr["theme"].ToString() == cb_theme.SelectedItem.ToString())
                {
                    string motif = dr["motif"].ToString();
                    if (!cb_motif.Items.Contains(motif))
                        cb_motif.Items.Add(motif);
                }
            }
        }

        private long GetSelectedActiviteId()
        {
            foreach(DataRow dr in _activites.Rows)
            {
                if (dr["date"].ToString() == cb_date.SelectedItem.ToString() &&
                    dr["lieu"].ToString() == cb_lieu.SelectedItem.ToString() &&
                    dr["theme"].ToString() == cb_theme.SelectedItem.ToString() &&
                    dr["motif"].ToString() == cb_theme.SelectedItem.ToString())
                {
                    return (long)dr["id"];
                }
            }
            throw new Exception("Impossible de trouver l'ID de l'activité selectionnée");
        }
        #endregion

        #region Méthodes évènementielles
        private void cb_date_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_idActivite != -1) return;
            LoadLieux();
            cb_lieu.Enabled = true;
            cb_theme.Enabled = false;
            cb_theme.Items.Clear();
            cb_motif.Enabled = false;
            cb_motif.Items.Clear();
        }

        private void cb_lieu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_idActivite != -1) return;
            LoadThemes();
            cb_theme.Enabled = true;
            cb_motif.Enabled = false;
            cb_motif.Items.Clear();
        }

        private void cb_theme_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_idActivite != -1) return;
            LoadMotifs();
            cb_motif.Enabled = true;
        }

        private void tb_specialiste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if(tb_specialiste.Text.Length == 0) return;

            e.Handled = true;
        }

        private void bt_valider_activite_Click(object sender, EventArgs e)
        {
            // Check
            if(cb_motif.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez renseigner une activité", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if(tb_specialiste.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner un specialiste", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Insert or update
            if(_idActivite == -1)
            {
                try
                {
                    DbDialog.InsertInviter(_idPraticien, GetSelectedActiviteId(), char.Parse(tb_specialiste.Text));
                } catch
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DbDialog.UpdateInviter(_idPraticien, _idActivite, char.Parse(tb_specialiste.Text));
                } catch
                {
                    MessageBox.Show("Erreur lors de la modification de l'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
