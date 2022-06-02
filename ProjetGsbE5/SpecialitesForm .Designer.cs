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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialitesForm));
            this.dgv_specialite = new System.Windows.Forms.DataGridView();
            this.cln_idspecialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_libspecialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_diplome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_coefprescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_specialite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_specialite
            // 
            this.dgv_specialite.AllowUserToAddRows = false;
            this.dgv_specialite.AllowUserToDeleteRows = false;
            this.dgv_specialite.AllowUserToResizeColumns = false;
            this.dgv_specialite.AllowUserToResizeRows = false;
            this.dgv_specialite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_specialite.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_specialite.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_specialite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_specialite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_specialite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_idspecialite,
            this.cln_libspecialite,
            this.cln_diplome,
            this.cln_coefprescription});
            this.dgv_specialite.Location = new System.Drawing.Point(12, 12);
            this.dgv_specialite.MultiSelect = false;
            this.dgv_specialite.Name = "dgv_specialite";
            this.dgv_specialite.ReadOnly = true;
            this.dgv_specialite.RowHeadersVisible = false;
            this.dgv_specialite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_specialite.Size = new System.Drawing.Size(365, 300);
            this.dgv_specialite.TabIndex = 0;
            this.dgv_specialite.CurrentCellChanged += new System.EventHandler(this.dgv_specialite_CurrentCellChanged);
            // 
            // cln_idspecialite
            // 
            this.cln_idspecialite.HeaderText = "Id";
            this.cln_idspecialite.Name = "cln_idspecialite";
            this.cln_idspecialite.ReadOnly = true;
            this.cln_idspecialite.Visible = false;
            // 
            // cln_libspecialite
            // 
            this.cln_libspecialite.HeaderText = "Libellé";
            this.cln_libspecialite.Name = "cln_libspecialite";
            this.cln_libspecialite.ReadOnly = true;
            // 
            // cln_diplome
            // 
            this.cln_diplome.HeaderText = "Diplôme";
            this.cln_diplome.Name = "cln_diplome";
            this.cln_diplome.ReadOnly = true;
            // 
            // cln_coefprescription
            // 
            this.cln_coefprescription.HeaderText = "Coef. Prescription";
            this.cln_coefprescription.Name = "cln_coefprescription";
            this.cln_coefprescription.ReadOnly = true;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(402, 40);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(134, 40);
            this.bt_ajouter.TabIndex = 1;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.Enabled = false;
            this.bt_modifier.Location = new System.Drawing.Point(402, 131);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(134, 40);
            this.bt_modifier.TabIndex = 2;
            this.bt_modifier.Text = "Modifier ";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Enabled = false;
            this.bt_supprimer.Location = new System.Drawing.Point(402, 234);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(134, 40);
            this.bt_supprimer.TabIndex = 3;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // SpecialitesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 336);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.dgv_specialite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpecialitesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_specialite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_specialite;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_idspecialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_libspecialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_diplome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_coefprescription;
    }
}