﻿namespace ProjetGsbE5
{
    partial class AjouterModifierSpecialiteForm
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
            this.lb_titre_sp = new System.Windows.Forms.Label();
            this.tb_libelle = new System.Windows.Forms.TextBox();
            this.bt_valider_sp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_coef = new System.Windows.Forms.TextBox();
            this.tb_diplome = new System.Windows.Forms.TextBox();
            this.bt_annuler_sp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titre_sp
            // 
            this.lb_titre_sp.AutoSize = true;
            this.lb_titre_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre_sp.Location = new System.Drawing.Point(90, 27);
            this.lb_titre_sp.Name = "lb_titre_sp";
            this.lb_titre_sp.Size = new System.Drawing.Size(309, 25);
            this.lb_titre_sp.TabIndex = 0;
            this.lb_titre_sp.Text = "Ajout/Modification spécialité";
            // 
            // tb_libelle
            // 
            this.tb_libelle.Location = new System.Drawing.Point(247, 80);
            this.tb_libelle.Name = "tb_libelle";
            this.tb_libelle.Size = new System.Drawing.Size(144, 20);
            this.tb_libelle.TabIndex = 1;
            // 
            // bt_valider_sp
            // 
            this.bt_valider_sp.Location = new System.Drawing.Point(95, 217);
            this.bt_valider_sp.Name = "bt_valider_sp";
            this.bt_valider_sp.Size = new System.Drawing.Size(109, 33);
            this.bt_valider_sp.TabIndex = 2;
            this.bt_valider_sp.Text = "Valider";
            this.bt_valider_sp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libellé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diplôme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coef. Prescription";
            // 
            // tb_coef
            // 
            this.tb_coef.Location = new System.Drawing.Point(247, 142);
            this.tb_coef.Name = "tb_coef";
            this.tb_coef.Size = new System.Drawing.Size(77, 20);
            this.tb_coef.TabIndex = 6;
            // 
            // tb_diplome
            // 
            this.tb_diplome.Location = new System.Drawing.Point(247, 111);
            this.tb_diplome.Name = "tb_diplome";
            this.tb_diplome.Size = new System.Drawing.Size(144, 20);
            this.tb_diplome.TabIndex = 7;
            // 
            // bt_annuler_sp
            // 
            this.bt_annuler_sp.Location = new System.Drawing.Point(290, 217);
            this.bt_annuler_sp.Name = "bt_annuler_sp";
            this.bt_annuler_sp.Size = new System.Drawing.Size(109, 33);
            this.bt_annuler_sp.TabIndex = 8;
            this.bt_annuler_sp.Text = "Annuler";
            this.bt_annuler_sp.UseVisualStyleBackColor = true;
            // 
            // AjouterModifierSpecialiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 301);
            this.Controls.Add(this.bt_annuler_sp);
            this.Controls.Add(this.tb_diplome);
            this.Controls.Add(this.tb_coef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_valider_sp);
            this.Controls.Add(this.tb_libelle);
            this.Controls.Add(this.lb_titre_sp);
            this.Name = "AjouterModifierSpecialiteForm";
            this.Text = "AjouterModifierSpecialiteForm";
            this.Load += new System.EventHandler(this.AjouterModifierSpecialiteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titre_sp;
        private System.Windows.Forms.TextBox tb_libelle;
        private System.Windows.Forms.Button bt_valider_sp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_coef;
        private System.Windows.Forms.TextBox tb_diplome;
        private System.Windows.Forms.Button bt_annuler_sp;
    }
}