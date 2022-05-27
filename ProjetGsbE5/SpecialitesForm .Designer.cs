namespace ProjetGsbE5
{
    partial class SpecialitesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_specialite = new System.Windows.Forms.DataGridView();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_specialite)).BeginInit();
            this.SuspendLayout();
            // 
            // Specialite
            // 
            this.Specialite.HeaderText = "Spécialités";
            this.Specialite.Name = "Specialite";
            // 
            // dgv_specialite
            // 
            this.dgv_specialite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_specialite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_specialite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Specialite});
            this.dgv_specialite.Location = new System.Drawing.Point(12, 12);
            this.dgv_specialite.Name = "dgv_specialite";
            this.dgv_specialite.RowHeadersVisible = false;
            this.dgv_specialite.Size = new System.Drawing.Size(240, 426);
            this.dgv_specialite.TabIndex = 0;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(322, 104);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(134, 40);
            this.bt_ajouter.TabIndex = 1;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(322, 188);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(134, 40);
            this.bt_modifier.TabIndex = 2;
            this.bt_modifier.Text = "Modifier ";
            this.bt_modifier.UseVisualStyleBackColor = true;
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Location = new System.Drawing.Point(322, 272);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(134, 40);
            this.bt_supprimer.TabIndex = 3;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            // 
            // SpecialitesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.dgv_specialite);
            this.Name = "SpecialitesForm";
            this.Text = "SpecialitesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_specialite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Specialite;
        private System.Windows.Forms.DataGridView dgv_specialite;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_supprimer;
    }
}