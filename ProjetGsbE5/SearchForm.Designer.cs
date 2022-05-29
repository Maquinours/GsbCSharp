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
            this.tc_search = new System.Windows.Forms.TabControl();
            this.tp_nom = new System.Windows.Forms.TabPage();
            this.tp_sp = new System.Windows.Forms.TabPage();
            this.bt_valider_search = new System.Windows.Forms.Button();
            this.bt_annuler_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tc_search.SuspendLayout();
            this.tp_nom.SuspendLayout();
            this.tp_sp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_search
            // 
            this.tc_search.Controls.Add(this.tp_nom);
            this.tc_search.Controls.Add(this.tp_sp);
            this.tc_search.Location = new System.Drawing.Point(12, 12);
            this.tc_search.Name = "tc_search";
            this.tc_search.SelectedIndex = 0;
            this.tc_search.Size = new System.Drawing.Size(364, 127);
            this.tc_search.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_search.TabIndex = 4;
            // 
            // tp_nom
            // 
            this.tp_nom.Controls.Add(this.tb_search);
            this.tp_nom.Controls.Add(this.label1);
            this.tp_nom.Location = new System.Drawing.Point(4, 22);
            this.tp_nom.Name = "tp_nom";
            this.tp_nom.Padding = new System.Windows.Forms.Padding(3);
            this.tp_nom.Size = new System.Drawing.Size(356, 101);
            this.tp_nom.TabIndex = 0;
            this.tp_nom.Text = "Nom";
            this.tp_nom.UseVisualStyleBackColor = true;
            // 
            // tp_sp
            // 
            this.tp_sp.Controls.Add(this.label2);
            this.tp_sp.Controls.Add(this.cb_search);
            this.tp_sp.Location = new System.Drawing.Point(4, 22);
            this.tp_sp.Name = "tp_sp";
            this.tp_sp.Padding = new System.Windows.Forms.Padding(3);
            this.tp_sp.Size = new System.Drawing.Size(356, 101);
            this.tp_sp.TabIndex = 1;
            this.tp_sp.Text = "Spécialité";
            this.tp_sp.UseVisualStyleBackColor = true;
            // 
            // bt_valider_search
            // 
            this.bt_valider_search.Location = new System.Drawing.Point(59, 156);
            this.bt_valider_search.Name = "bt_valider_search";
            this.bt_valider_search.Size = new System.Drawing.Size(102, 23);
            this.bt_valider_search.TabIndex = 5;
            this.bt_valider_search.Text = "Valider";
            this.bt_valider_search.UseVisualStyleBackColor = true;
            // 
            // bt_annuler_search
            // 
            this.bt_annuler_search.Location = new System.Drawing.Point(228, 156);
            this.bt_annuler_search.Name = "bt_annuler_search";
            this.bt_annuler_search.Size = new System.Drawing.Size(102, 23);
            this.bt_annuler_search.TabIndex = 6;
            this.bt_annuler_search.Text = "Annuler";
            this.bt_annuler_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Par nom :";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(103, 39);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(135, 20);
            this.tb_search.TabIndex = 1;
            // 
            // cb_search
            // 
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(103, 39);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(135, 21);
            this.cb_search.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Par spécialité :";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.bt_annuler_search);
            this.Controls.Add(this.bt_valider_search);
            this.Controls.Add(this.tc_search);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.tc_search.ResumeLayout(false);
            this.tp_nom.ResumeLayout(false);
            this.tp_nom.PerformLayout();
            this.tp_sp.ResumeLayout(false);
            this.tp_sp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_search;
        private System.Windows.Forms.TabPage tp_nom;
        private System.Windows.Forms.TabPage tp_sp;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Button bt_valider_search;
        private System.Windows.Forms.Button bt_annuler_search;
    }
}