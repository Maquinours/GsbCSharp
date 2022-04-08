namespace ProjetGsbE5
{
    partial class SearchForm
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
            this.tb_rechercher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_rechercher = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_rechercher
            // 
            this.tb_rechercher.Location = new System.Drawing.Point(58, 56);
            this.tb_rechercher.Name = "tb_rechercher";
            this.tb_rechercher.Size = new System.Drawing.Size(225, 20);
            this.tb_rechercher.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rechercher un praticien par nom ou spécialité";
            // 
            // bt_rechercher
            // 
            this.bt_rechercher.Location = new System.Drawing.Point(58, 93);
            this.bt_rechercher.Name = "bt_rechercher";
            this.bt_rechercher.Size = new System.Drawing.Size(75, 23);
            this.bt_rechercher.TabIndex = 1;
            this.bt_rechercher.Text = "Rechercher";
            this.bt_rechercher.UseVisualStyleBackColor = true;
            this.bt_rechercher.Click += new System.EventHandler(this.bt_rechercher_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(208, 93);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 2;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // Search
            // 
            this.AcceptButton = this.bt_rechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 148);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_rechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_rechercher);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_rechercher;
        private System.Windows.Forms.Button bt_annuler;
    }
}