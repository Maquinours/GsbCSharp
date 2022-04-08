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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_praticiens = new System.Windows.Forms.TabPage();
            this.dgv_praticiens = new System.Windows.Forms.DataGridView();
            this.column_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_control.SuspendLayout();
            this.tab_praticiens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_praticiens)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_praticiens);
            this.tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control.Location = new System.Drawing.Point(0, 0);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(784, 561);
            this.tab_control.TabIndex = 0;
            this.tab_control.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_control_Selected);
            // 
            // tab_praticiens
            // 
            this.tab_praticiens.Controls.Add(this.dgv_praticiens);
            this.tab_praticiens.Location = new System.Drawing.Point(4, 22);
            this.tab_praticiens.Name = "tab_praticiens";
            this.tab_praticiens.Padding = new System.Windows.Forms.Padding(3);
            this.tab_praticiens.Size = new System.Drawing.Size(776, 535);
            this.tab_praticiens.TabIndex = 1;
            this.tab_praticiens.Text = "Praticiens";
            this.tab_praticiens.UseVisualStyleBackColor = true;
            // 
            // dgv_praticiens
            // 
            this.dgv_praticiens.AllowUserToAddRows = false;
            this.dgv_praticiens.AllowUserToDeleteRows = false;
            this.dgv_praticiens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_praticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_praticiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_nom,
            this.column_prenom,
            this.column_specialite,
            this.column_type,
            this.column_adresse});
            this.dgv_praticiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_praticiens.Location = new System.Drawing.Point(3, 3);
            this.dgv_praticiens.Name = "dgv_praticiens";
            this.dgv_praticiens.Size = new System.Drawing.Size(770, 529);
            this.dgv_praticiens.TabIndex = 0;
            // 
            // column_nom
            // 
            this.column_nom.HeaderText = "Nom";
            this.column_nom.Name = "column_nom";
            // 
            // column_prenom
            // 
            this.column_prenom.HeaderText = "Prénom";
            this.column_prenom.Name = "column_prenom";
            // 
            // column_specialite
            // 
            this.column_specialite.HeaderText = "Spécialité";
            this.column_specialite.Name = "column_specialite";
            // 
            // column_type
            // 
            this.column_type.HeaderText = "Type";
            this.column_type.Name = "column_type";
            // 
            // column_adresse
            // 
            this.column_adresse.HeaderText = "Adresse";
            this.column_adresse.Name = "column_adresse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tab_control);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tab_control.ResumeLayout(false);
            this.tab_praticiens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_praticiens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_praticiens;
        private System.Windows.Forms.DataGridView dgv_praticiens;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_specialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_adresse;
    }
}

