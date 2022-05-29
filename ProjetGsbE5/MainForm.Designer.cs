namespace ProjetGsbE5
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_praticiens = new System.Windows.Forms.DataGridView();
            this.cln_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_specialites = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cln_activites = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_praticiens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_praticiens
            // 
            this.dgv_praticiens.AllowUserToAddRows = false;
            this.dgv_praticiens.AllowUserToDeleteRows = false;
            this.dgv_praticiens.AllowUserToResizeColumns = false;
            this.dgv_praticiens.AllowUserToResizeRows = false;
            this.dgv_praticiens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_praticiens.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_praticiens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_praticiens.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_praticiens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_praticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_praticiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_id,
            this.cln_nom,
            this.cln_prenom,
            this.cln_type,
            this.cln_adresse,
            this.cln_specialites,
            this.cln_activites});
            this.dgv_praticiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_praticiens.Location = new System.Drawing.Point(0, 0);
            this.dgv_praticiens.Name = "dgv_praticiens";
            this.dgv_praticiens.ReadOnly = true;
            this.dgv_praticiens.RowHeadersVisible = false;
            this.dgv_praticiens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_praticiens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_praticiens.ShowCellErrors = false;
            this.dgv_praticiens.ShowCellToolTips = false;
            this.dgv_praticiens.ShowEditingIcon = false;
            this.dgv_praticiens.ShowRowErrors = false;
            this.dgv_praticiens.Size = new System.Drawing.Size(784, 561);
            this.dgv_praticiens.StandardTab = true;
            this.dgv_praticiens.TabIndex = 1;
            this.dgv_praticiens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_praticiens_CellContentClick);
            // 
            // cln_id
            // 
            this.cln_id.HeaderText = "Id";
            this.cln_id.Name = "cln_id";
            this.cln_id.ReadOnly = true;
            this.cln_id.Visible = false;
            // 
            // cln_nom
            // 
            this.cln_nom.HeaderText = "Nom";
            this.cln_nom.Name = "cln_nom";
            this.cln_nom.ReadOnly = true;
            // 
            // cln_prenom
            // 
            this.cln_prenom.HeaderText = "Prénom";
            this.cln_prenom.Name = "cln_prenom";
            this.cln_prenom.ReadOnly = true;
            // 
            // cln_type
            // 
            this.cln_type.HeaderText = "Type";
            this.cln_type.Name = "cln_type";
            this.cln_type.ReadOnly = true;
            // 
            // cln_adresse
            // 
            this.cln_adresse.HeaderText = "Adresse";
            this.cln_adresse.Name = "cln_adresse";
            this.cln_adresse.ReadOnly = true;
            // 
            // cln_specialites
            // 
            this.cln_specialites.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cln_specialites.HeaderText = "Spécialités";
            this.cln_specialites.Name = "cln_specialites";
            this.cln_specialites.ReadOnly = true;
            this.cln_specialites.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cln_specialites.Width = 64;
            // 
            // cln_activites
            // 
            this.cln_activites.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cln_activites.HeaderText = "Activités";
            this.cln_activites.Name = "cln_activites";
            this.cln_activites.ReadOnly = true;
            this.cln_activites.Width = 53;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgv_praticiens);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "GSB Praticiens";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_praticiens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_praticiens;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_adresse;
        private System.Windows.Forms.DataGridViewButtonColumn cln_specialites;
        private System.Windows.Forms.DataGridViewButtonColumn cln_activites;
    }
}

