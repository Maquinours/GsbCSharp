namespace ProjetGsbE5
{
    partial class ActivitesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitesForm));
            this.dgv_activite = new System.Windows.Forms.DataGridView();
            this.cln_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_lieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_specialiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_ajouter_activite = new System.Windows.Forms.Button();
            this.bt_modifier_activite = new System.Windows.Forms.Button();
            this.bt_supprimer_activite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_activite
            // 
            this.dgv_activite.AllowUserToAddRows = false;
            this.dgv_activite.AllowUserToDeleteRows = false;
            this.dgv_activite.AllowUserToResizeColumns = false;
            this.dgv_activite.AllowUserToResizeRows = false;
            this.dgv_activite.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_activite.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_activite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_activite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_activite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_id,
            this.cln_date,
            this.cln_lieu,
            this.cln_theme,
            this.cln_motif,
            this.cln_specialiste});
            this.dgv_activite.Location = new System.Drawing.Point(12, 12);
            this.dgv_activite.MultiSelect = false;
            this.dgv_activite.Name = "dgv_activite";
            this.dgv_activite.ReadOnly = true;
            this.dgv_activite.RowHeadersVisible = false;
            this.dgv_activite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_activite.Size = new System.Drawing.Size(503, 315);
            this.dgv_activite.TabIndex = 0;
            this.dgv_activite.CurrentCellChanged += new System.EventHandler(this.dgv_activite_CurrentCellChanged);
            // 
            // cln_id
            // 
            this.cln_id.HeaderText = "Id";
            this.cln_id.Name = "cln_id";
            this.cln_id.ReadOnly = true;
            this.cln_id.Visible = false;
            // 
            // cln_date
            // 
            this.cln_date.HeaderText = "Date";
            this.cln_date.Name = "cln_date";
            this.cln_date.ReadOnly = true;
            // 
            // cln_lieu
            // 
            this.cln_lieu.HeaderText = "Lieu";
            this.cln_lieu.Name = "cln_lieu";
            this.cln_lieu.ReadOnly = true;
            // 
            // cln_theme
            // 
            this.cln_theme.HeaderText = "Thème";
            this.cln_theme.Name = "cln_theme";
            this.cln_theme.ReadOnly = true;
            // 
            // cln_motif
            // 
            this.cln_motif.HeaderText = "Motif";
            this.cln_motif.Name = "cln_motif";
            this.cln_motif.ReadOnly = true;
            // 
            // cln_specialiste
            // 
            this.cln_specialiste.HeaderText = "Specialiste";
            this.cln_specialiste.Name = "cln_specialiste";
            this.cln_specialiste.ReadOnly = true;
            // 
            // bt_ajouter_activite
            // 
            this.bt_ajouter_activite.Location = new System.Drawing.Point(540, 55);
            this.bt_ajouter_activite.Name = "bt_ajouter_activite";
            this.bt_ajouter_activite.Size = new System.Drawing.Size(134, 40);
            this.bt_ajouter_activite.TabIndex = 1;
            this.bt_ajouter_activite.Text = "Ajouter";
            this.bt_ajouter_activite.UseVisualStyleBackColor = true;
            this.bt_ajouter_activite.Click += new System.EventHandler(this.bt_ajouter_activite_Click);
            // 
            // bt_modifier_activite
            // 
            this.bt_modifier_activite.Enabled = false;
            this.bt_modifier_activite.Location = new System.Drawing.Point(540, 136);
            this.bt_modifier_activite.Name = "bt_modifier_activite";
            this.bt_modifier_activite.Size = new System.Drawing.Size(134, 40);
            this.bt_modifier_activite.TabIndex = 2;
            this.bt_modifier_activite.Text = "Modifier ";
            this.bt_modifier_activite.UseVisualStyleBackColor = true;
            this.bt_modifier_activite.Click += new System.EventHandler(this.bt_modifier_activite_Click);
            // 
            // bt_supprimer_activite
            // 
            this.bt_supprimer_activite.Enabled = false;
            this.bt_supprimer_activite.Location = new System.Drawing.Point(540, 220);
            this.bt_supprimer_activite.Name = "bt_supprimer_activite";
            this.bt_supprimer_activite.Size = new System.Drawing.Size(134, 40);
            this.bt_supprimer_activite.TabIndex = 3;
            this.bt_supprimer_activite.Text = "Supprimer";
            this.bt_supprimer_activite.UseVisualStyleBackColor = true;
            this.bt_supprimer_activite.Click += new System.EventHandler(this.bt_supprimer_activite_Click);
            // 
            // ActivitesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 341);
            this.Controls.Add(this.bt_supprimer_activite);
            this.Controls.Add(this.bt_modifier_activite);
            this.Controls.Add(this.bt_ajouter_activite);
            this.Controls.Add(this.dgv_activite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActivitesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_activite;
        private System.Windows.Forms.Button bt_ajouter_activite;
        private System.Windows.Forms.Button bt_modifier_activite;
        private System.Windows.Forms.Button bt_supprimer_activite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_lieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_motif;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_specialiste;
    }
}