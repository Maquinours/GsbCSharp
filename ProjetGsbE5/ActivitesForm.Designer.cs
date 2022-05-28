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
            this.dgv_activite = new System.Windows.Forms.DataGridView();
            this.bt_ajouter_activite = new System.Windows.Forms.Button();
            this.bt_modifier_activite = new System.Windows.Forms.Button();
            this.bt_supprimer_activite = new System.Windows.Forms.Button();
            this.lb_activite = new System.Windows.Forms.Label();
            this.date_activite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieu_activite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theme_activite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motif_activite = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.date_activite,
            this.lieu_activite,
            this.theme_activite,
            this.motif_activite});
            this.dgv_activite.Location = new System.Drawing.Point(12, 12);
            this.dgv_activite.Name = "dgv_activite";
            this.dgv_activite.ReadOnly = true;
            this.dgv_activite.RowHeadersVisible = false;
            this.dgv_activite.Size = new System.Drawing.Size(404, 426);
            this.dgv_activite.TabIndex = 0;
            // 
            // bt_ajouter_activite
            // 
            this.bt_ajouter_activite.Location = new System.Drawing.Point(494, 105);
            this.bt_ajouter_activite.Name = "bt_ajouter_activite";
            this.bt_ajouter_activite.Size = new System.Drawing.Size(134, 40);
            this.bt_ajouter_activite.TabIndex = 1;
            this.bt_ajouter_activite.Text = "Ajouter";
            this.bt_ajouter_activite.UseVisualStyleBackColor = true;
            // 
            // bt_modifier_activite
            // 
            this.bt_modifier_activite.Location = new System.Drawing.Point(494, 189);
            this.bt_modifier_activite.Name = "bt_modifier_activite";
            this.bt_modifier_activite.Size = new System.Drawing.Size(134, 40);
            this.bt_modifier_activite.TabIndex = 2;
            this.bt_modifier_activite.Text = "Modifier ";
            this.bt_modifier_activite.UseVisualStyleBackColor = true;
            // 
            // bt_supprimer_activite
            // 
            this.bt_supprimer_activite.Location = new System.Drawing.Point(494, 273);
            this.bt_supprimer_activite.Name = "bt_supprimer_activite";
            this.bt_supprimer_activite.Size = new System.Drawing.Size(134, 40);
            this.bt_supprimer_activite.TabIndex = 3;
            this.bt_supprimer_activite.Text = "Supprimer";
            this.bt_supprimer_activite.UseVisualStyleBackColor = true;
            // 
            // lb_activite
            // 
            this.lb_activite.AutoSize = true;
            this.lb_activite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_activite.Location = new System.Drawing.Point(422, 12);
            this.lb_activite.Name = "lb_activite";
            this.lb_activite.Size = new System.Drawing.Size(107, 20);
            this.lb_activite.TabIndex = 4;
            this.lb_activite.Text = "Activités de ";
            // 
            // date_activite
            // 
            this.date_activite.HeaderText = "Date";
            this.date_activite.Name = "date_activite";
            this.date_activite.ReadOnly = true;
            // 
            // lieu_activite
            // 
            this.lieu_activite.HeaderText = "Lieu";
            this.lieu_activite.Name = "lieu_activite";
            this.lieu_activite.ReadOnly = true;
            // 
            // theme_activite
            // 
            this.theme_activite.HeaderText = "Thème";
            this.theme_activite.Name = "theme_activite";
            this.theme_activite.ReadOnly = true;
            // 
            // motif_activite
            // 
            this.motif_activite.HeaderText = "Motif";
            this.motif_activite.Name = "motif_activite";
            this.motif_activite.ReadOnly = true;
            // 
            // ActivitesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.lb_activite);
            this.Controls.Add(this.bt_supprimer_activite);
            this.Controls.Add(this.bt_modifier_activite);
            this.Controls.Add(this.bt_ajouter_activite);
            this.Controls.Add(this.dgv_activite);
            this.Name = "ActivitesForm";
            this.Text = "ActivitesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_activite;
        private System.Windows.Forms.Button bt_ajouter_activite;
        private System.Windows.Forms.Button bt_modifier_activite;
        private System.Windows.Forms.Button bt_supprimer_activite;
        private System.Windows.Forms.Label lb_activite;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_activite;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieu_activite;
        private System.Windows.Forms.DataGridViewTextBoxColumn theme_activite;
        private System.Windows.Forms.DataGridViewTextBoxColumn motif_activite;
    }
}