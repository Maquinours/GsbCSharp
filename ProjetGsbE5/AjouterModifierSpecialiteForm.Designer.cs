namespace ProjetGsbE5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterModifierSpecialiteForm));
            this.bt_valider_sp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_coef = new System.Windows.Forms.TextBox();
            this.tb_diplome = new System.Windows.Forms.TextBox();
            this.bt_annuler_sp = new System.Windows.Forms.Button();
            this.cb_libelle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_valider_sp
            // 
            this.bt_valider_sp.Location = new System.Drawing.Point(32, 128);
            this.bt_valider_sp.Name = "bt_valider_sp";
            this.bt_valider_sp.Size = new System.Drawing.Size(109, 33);
            this.bt_valider_sp.TabIndex = 2;
            this.bt_valider_sp.Text = "Valider";
            this.bt_valider_sp.UseVisualStyleBackColor = true;
            this.bt_valider_sp.Click += new System.EventHandler(this.bt_valider_sp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libellé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diplôme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coef. Prescription";
            // 
            // tb_coef
            // 
            this.tb_coef.Location = new System.Drawing.Point(181, 80);
            this.tb_coef.Name = "tb_coef";
            this.tb_coef.Size = new System.Drawing.Size(77, 20);
            this.tb_coef.TabIndex = 6;
            this.tb_coef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_coef_KeyPress);
            // 
            // tb_diplome
            // 
            this.tb_diplome.Location = new System.Drawing.Point(181, 49);
            this.tb_diplome.Name = "tb_diplome";
            this.tb_diplome.Size = new System.Drawing.Size(144, 20);
            this.tb_diplome.TabIndex = 7;
            this.tb_diplome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_diplome_KeyPress);
            // 
            // bt_annuler_sp
            // 
            this.bt_annuler_sp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_annuler_sp.Location = new System.Drawing.Point(227, 128);
            this.bt_annuler_sp.Name = "bt_annuler_sp";
            this.bt_annuler_sp.Size = new System.Drawing.Size(109, 33);
            this.bt_annuler_sp.TabIndex = 8;
            this.bt_annuler_sp.Text = "Annuler";
            this.bt_annuler_sp.UseVisualStyleBackColor = true;
            // 
            // cb_libelle
            // 
            this.cb_libelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_libelle.FormattingEnabled = true;
            this.cb_libelle.Location = new System.Drawing.Point(181, 17);
            this.cb_libelle.Name = "cb_libelle";
            this.cb_libelle.Size = new System.Drawing.Size(121, 21);
            this.cb_libelle.TabIndex = 9;
            // 
            // AjouterModifierSpecialiteForm
            // 
            this.AcceptButton = this.bt_valider_sp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_annuler_sp;
            this.ClientSize = new System.Drawing.Size(366, 170);
            this.Controls.Add(this.cb_libelle);
            this.Controls.Add(this.bt_annuler_sp);
            this.Controls.Add(this.tb_diplome);
            this.Controls.Add(this.tb_coef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_valider_sp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AjouterModifierSpecialiteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_valider_sp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_coef;
        private System.Windows.Forms.TextBox tb_diplome;
        private System.Windows.Forms.Button bt_annuler_sp;
        private System.Windows.Forms.ComboBox cb_libelle;
    }
}