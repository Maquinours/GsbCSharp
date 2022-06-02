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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgv_praticiens = new System.Windows.Forms.DataGridView();
            this.cln_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_specialites = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cln_activites = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_rechercher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_affichertout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_praticiens)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dgv_praticiens.Location = new System.Drawing.Point(0, 24);
            this.dgv_praticiens.Name = "dgv_praticiens";
            this.dgv_praticiens.ReadOnly = true;
            this.dgv_praticiens.RowHeadersVisible = false;
            this.dgv_praticiens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_praticiens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_praticiens.ShowCellErrors = false;
            this.dgv_praticiens.ShowCellToolTips = false;
            this.dgv_praticiens.ShowEditingIcon = false;
            this.dgv_praticiens.ShowRowErrors = false;
            this.dgv_praticiens.Size = new System.Drawing.Size(784, 537);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_fichier,
            this.tsmi_edition});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_fichier
            // 
            this.tsmi_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_deconnexion,
            this.tsmi_quitter});
            this.tsmi_fichier.Name = "tsmi_fichier";
            this.tsmi_fichier.Size = new System.Drawing.Size(54, 20);
            this.tsmi_fichier.Text = "Fichier";
            // 
            // tsmi_deconnexion
            // 
            this.tsmi_deconnexion.Name = "tsmi_deconnexion";
            this.tsmi_deconnexion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmi_deconnexion.Size = new System.Drawing.Size(186, 22);
            this.tsmi_deconnexion.Text = "Deconnexion";
            this.tsmi_deconnexion.Click += new System.EventHandler(this.tsmi_deconnexion_Click);
            // 
            // tsmi_quitter
            // 
            this.tsmi_quitter.Name = "tsmi_quitter";
            this.tsmi_quitter.ShortcutKeyDisplayString = "";
            this.tsmi_quitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmi_quitter.Size = new System.Drawing.Size(186, 22);
            this.tsmi_quitter.Text = "Quitter";
            this.tsmi_quitter.Click += new System.EventHandler(this.tsmi_quitter_Click);
            // 
            // tsmi_edition
            // 
            this.tsmi_edition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_rechercher,
            this.tsmi_affichertout});
            this.tsmi_edition.Name = "tsmi_edition";
            this.tsmi_edition.Size = new System.Drawing.Size(56, 20);
            this.tsmi_edition.Text = "Edition";
            // 
            // tsmi_rechercher
            // 
            this.tsmi_rechercher.Name = "tsmi_rechercher";
            this.tsmi_rechercher.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmi_rechercher.Size = new System.Drawing.Size(182, 22);
            this.tsmi_rechercher.Text = "Rechercher";
            this.tsmi_rechercher.Click += new System.EventHandler(this.tsmi_rechercher_Click);
            // 
            // tsmi_affichertout
            // 
            this.tsmi_affichertout.Enabled = false;
            this.tsmi_affichertout.Name = "tsmi_affichertout";
            this.tsmi_affichertout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmi_affichertout.Size = new System.Drawing.Size(182, 22);
            this.tsmi_affichertout.Text = "Afficher tout";
            this.tsmi_affichertout.Click += new System.EventHandler(this.tsmi_affichertout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgv_praticiens);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "GSB Praticiens";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_praticiens)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_praticiens;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fichier;
        private System.Windows.Forms.ToolStripMenuItem tsmi_deconnexion;
        private System.Windows.Forms.ToolStripMenuItem tsmi_quitter;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edition;
        private System.Windows.Forms.ToolStripMenuItem tsmi_rechercher;
        private System.Windows.Forms.ToolStripMenuItem tsmi_affichertout;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_adresse;
        private System.Windows.Forms.DataGridViewButtonColumn cln_specialites;
        private System.Windows.Forms.DataGridViewButtonColumn cln_activites;
    }
}

