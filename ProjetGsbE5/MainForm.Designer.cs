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
            this.dgv_praticiens = new System.Windows.Forms.DataGridView();
            this.column_adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgv_praticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_praticiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_nom,
            this.column_prenom,
            this.column_type,
            this.column_adresse});
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
            // 
            // column_adresse
            // 
            this.column_adresse.HeaderText = "Adresse";
            this.column_adresse.Name = "column_adresse";
            this.column_adresse.ReadOnly = true;
            // 
            // column_type
            // 
            this.column_type.HeaderText = "Type";
            this.column_type.Name = "column_type";
            this.column_type.ReadOnly = true;
            // 
            // column_prenom
            // 
            this.column_prenom.HeaderText = "Prénom";
            this.column_prenom.Name = "column_prenom";
            this.column_prenom.ReadOnly = true;
            // 
            // column_nom
            // 
            this.column_nom.HeaderText = "Nom";
            this.column_nom.Name = "column_nom";
            this.column_nom.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn column_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_adresse;
    }
}

