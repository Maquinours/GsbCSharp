namespace ProjetGsbE5
{
    partial class AjouterModifierActiviteForm
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
            this.bt_valider_activite = new System.Windows.Forms.Button();
            this.bt_annuler_activite = new System.Windows.Forms.Button();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.lb_titre_activite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_lieu = new System.Windows.Forms.TextBox();
            this.tb_theme = new System.Windows.Forms.TextBox();
            this.tb_motif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_valider_activite
            // 
            this.bt_valider_activite.Location = new System.Drawing.Point(95, 217);
            this.bt_valider_activite.Name = "bt_valider_activite";
            this.bt_valider_activite.Size = new System.Drawing.Size(109, 33);
            this.bt_valider_activite.TabIndex = 0;
            this.bt_valider_activite.Text = "Valider";
            this.bt_valider_activite.UseVisualStyleBackColor = true;
            // 
            // bt_annuler_activite
            // 
            this.bt_annuler_activite.Location = new System.Drawing.Point(290, 217);
            this.bt_annuler_activite.Name = "bt_annuler_activite";
            this.bt_annuler_activite.Size = new System.Drawing.Size(109, 33);
            this.bt_annuler_activite.TabIndex = 1;
            this.bt_annuler_activite.Text = "Annuler";
            this.bt_annuler_activite.UseVisualStyleBackColor = true;
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(209, 78);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(97, 20);
            this.tb_date.TabIndex = 2;
            // 
            // lb_titre_activite
            // 
            this.lb_titre_activite.AutoSize = true;
            this.lb_titre_activite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre_activite.Location = new System.Drawing.Point(90, 28);
            this.lb_titre_activite.Name = "lb_titre_activite";
            this.lb_titre_activite.Size = new System.Drawing.Size(284, 25);
            this.lb_titre_activite.TabIndex = 3;
            this.lb_titre_activite.Text = "Ajout/Modification activité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lieu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thème";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Motif";
            // 
            // tb_lieu
            // 
            this.tb_lieu.Location = new System.Drawing.Point(209, 110);
            this.tb_lieu.Name = "tb_lieu";
            this.tb_lieu.Size = new System.Drawing.Size(140, 20);
            this.tb_lieu.TabIndex = 8;
            // 
            // tb_theme
            // 
            this.tb_theme.Location = new System.Drawing.Point(209, 141);
            this.tb_theme.Name = "tb_theme";
            this.tb_theme.Size = new System.Drawing.Size(140, 20);
            this.tb_theme.TabIndex = 9;
            // 
            // tb_motif
            // 
            this.tb_motif.Location = new System.Drawing.Point(209, 171);
            this.tb_motif.Name = "tb_motif";
            this.tb_motif.Size = new System.Drawing.Size(140, 20);
            this.tb_motif.TabIndex = 10;
            // 
            // AjouterModifierActiviteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 301);
            this.Controls.Add(this.tb_motif);
            this.Controls.Add(this.tb_theme);
            this.Controls.Add(this.tb_lieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_titre_activite);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.bt_annuler_activite);
            this.Controls.Add(this.bt_valider_activite);
            this.Name = "AjouterModifierActiviteForm";
            this.Text = "AjouterModifierActiviteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_valider_activite;
        private System.Windows.Forms.Button bt_annuler_activite;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label lb_titre_activite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_lieu;
        private System.Windows.Forms.TextBox tb_theme;
        private System.Windows.Forms.TextBox tb_motif;
    }
}