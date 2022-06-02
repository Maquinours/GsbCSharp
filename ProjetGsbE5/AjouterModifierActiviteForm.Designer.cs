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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterModifierActiviteForm));
            this.bt_valider_activite = new System.Windows.Forms.Button();
            this.bt_annuler_activite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.cb_lieu = new System.Windows.Forms.ComboBox();
            this.cb_theme = new System.Windows.Forms.ComboBox();
            this.cb_motif = new System.Windows.Forms.ComboBox();
            this.lb_specialiste = new System.Windows.Forms.Label();
            this.tb_specialiste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_valider_activite
            // 
            this.bt_valider_activite.Location = new System.Drawing.Point(35, 202);
            this.bt_valider_activite.Name = "bt_valider_activite";
            this.bt_valider_activite.Size = new System.Drawing.Size(109, 33);
            this.bt_valider_activite.TabIndex = 0;
            this.bt_valider_activite.Text = "Valider";
            this.bt_valider_activite.UseVisualStyleBackColor = true;
            this.bt_valider_activite.Click += new System.EventHandler(this.bt_valider_activite_Click);
            // 
            // bt_annuler_activite
            // 
            this.bt_annuler_activite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_annuler_activite.Location = new System.Drawing.Point(225, 202);
            this.bt_annuler_activite.Name = "bt_annuler_activite";
            this.bt_annuler_activite.Size = new System.Drawing.Size(109, 33);
            this.bt_annuler_activite.TabIndex = 1;
            this.bt_annuler_activite.Text = "Annuler";
            this.bt_annuler_activite.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lieu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thème";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Motif";
            // 
            // cb_date
            // 
            this.cb_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Location = new System.Drawing.Point(149, 25);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(121, 21);
            this.cb_date.TabIndex = 11;
            this.cb_date.SelectedValueChanged += new System.EventHandler(this.cb_date_SelectedValueChanged);
            // 
            // cb_lieu
            // 
            this.cb_lieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lieu.Enabled = false;
            this.cb_lieu.FormattingEnabled = true;
            this.cb_lieu.Location = new System.Drawing.Point(149, 57);
            this.cb_lieu.Name = "cb_lieu";
            this.cb_lieu.Size = new System.Drawing.Size(121, 21);
            this.cb_lieu.TabIndex = 12;
            this.cb_lieu.SelectedValueChanged += new System.EventHandler(this.cb_lieu_SelectedValueChanged);
            // 
            // cb_theme
            // 
            this.cb_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_theme.Enabled = false;
            this.cb_theme.FormattingEnabled = true;
            this.cb_theme.Location = new System.Drawing.Point(149, 88);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(121, 21);
            this.cb_theme.TabIndex = 13;
            this.cb_theme.SelectedValueChanged += new System.EventHandler(this.cb_theme_SelectedValueChanged);
            // 
            // cb_motif
            // 
            this.cb_motif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_motif.Enabled = false;
            this.cb_motif.FormattingEnabled = true;
            this.cb_motif.Location = new System.Drawing.Point(149, 121);
            this.cb_motif.Name = "cb_motif";
            this.cb_motif.Size = new System.Drawing.Size(121, 21);
            this.cb_motif.TabIndex = 14;
            // 
            // lb_specialiste
            // 
            this.lb_specialiste.AutoSize = true;
            this.lb_specialiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_specialiste.Location = new System.Drawing.Point(40, 156);
            this.lb_specialiste.Name = "lb_specialiste";
            this.lb_specialiste.Size = new System.Drawing.Size(79, 18);
            this.lb_specialiste.TabIndex = 15;
            this.lb_specialiste.Text = "Specialiste";
            // 
            // tb_specialiste
            // 
            this.tb_specialiste.Location = new System.Drawing.Point(149, 157);
            this.tb_specialiste.Name = "tb_specialiste";
            this.tb_specialiste.Size = new System.Drawing.Size(35, 20);
            this.tb_specialiste.TabIndex = 16;
            this.tb_specialiste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_specialiste_KeyPress);
            // 
            // AjouterModifierActiviteForm
            // 
            this.AcceptButton = this.bt_valider_activite;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_annuler_activite;
            this.ClientSize = new System.Drawing.Size(363, 251);
            this.Controls.Add(this.tb_specialiste);
            this.Controls.Add(this.lb_specialiste);
            this.Controls.Add(this.cb_motif);
            this.Controls.Add(this.cb_theme);
            this.Controls.Add(this.cb_lieu);
            this.Controls.Add(this.cb_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_annuler_activite);
            this.Controls.Add(this.bt_valider_activite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AjouterModifierActiviteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_valider_activite;
        private System.Windows.Forms.Button bt_annuler_activite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.ComboBox cb_lieu;
        private System.Windows.Forms.ComboBox cb_theme;
        private System.Windows.Forms.ComboBox cb_motif;
        private System.Windows.Forms.Label lb_specialiste;
        private System.Windows.Forms.TextBox tb_specialiste;
    }
}