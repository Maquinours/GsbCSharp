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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.tc_search = new System.Windows.Forms.TabControl();
            this.tp_nom = new System.Windows.Forms.TabPage();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_sp = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_specialites = new System.Windows.Forms.ComboBox();
            this.bt_valider_search = new System.Windows.Forms.Button();
            this.bt_annuler_search = new System.Windows.Forms.Button();
            this.tp_type = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_types = new System.Windows.Forms.ComboBox();
            this.tc_search.SuspendLayout();
            this.tp_nom.SuspendLayout();
            this.tp_sp.SuspendLayout();
            this.tp_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_search
            // 
            this.tc_search.Controls.Add(this.tp_nom);
            this.tc_search.Controls.Add(this.tp_sp);
            this.tc_search.Controls.Add(this.tp_type);
            this.tc_search.Location = new System.Drawing.Point(12, 12);
            this.tc_search.Name = "tc_search";
            this.tc_search.SelectedIndex = 0;
            this.tc_search.ShowToolTips = true;
            this.tc_search.Size = new System.Drawing.Size(364, 127);
            this.tc_search.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_search.TabIndex = 4;
            this.tc_search.SelectedIndexChanged += new System.EventHandler(this.tc_search_SelectedIndexChanged);
            // 
            // tp_nom
            // 
            this.tp_nom.Controls.Add(this.tb_nom);
            this.tp_nom.Controls.Add(this.label1);
            this.tp_nom.Location = new System.Drawing.Point(4, 22);
            this.tp_nom.Name = "tp_nom";
            this.tp_nom.Padding = new System.Windows.Forms.Padding(3);
            this.tp_nom.Size = new System.Drawing.Size(356, 101);
            this.tp_nom.TabIndex = 0;
            this.tp_nom.Text = "Nom";
            this.tp_nom.ToolTipText = "Effectuer une recherche selon un nom";
            this.tp_nom.UseVisualStyleBackColor = true;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(140, 39);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(135, 20);
            this.tb_nom.TabIndex = 1;
            this.tb_nom.TextChanged += new System.EventHandler(this.tb_nom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // tp_sp
            // 
            this.tp_sp.Controls.Add(this.label2);
            this.tp_sp.Controls.Add(this.cb_specialites);
            this.tp_sp.Location = new System.Drawing.Point(4, 22);
            this.tp_sp.Name = "tp_sp";
            this.tp_sp.Padding = new System.Windows.Forms.Padding(3);
            this.tp_sp.Size = new System.Drawing.Size(356, 101);
            this.tp_sp.TabIndex = 1;
            this.tp_sp.Text = "Spécialité";
            this.tp_sp.ToolTipText = "Effectuer une recherche selon une spécialité";
            this.tp_sp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spécialité :";
            // 
            // cb_specialites
            // 
            this.cb_specialites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_specialites.FormattingEnabled = true;
            this.cb_specialites.Location = new System.Drawing.Point(140, 39);
            this.cb_specialites.Name = "cb_specialites";
            this.cb_specialites.Size = new System.Drawing.Size(135, 21);
            this.cb_specialites.TabIndex = 0;
            this.cb_specialites.SelectedIndexChanged += new System.EventHandler(this.cb_specialites_SelectedIndexChanged);
            // 
            // bt_valider_search
            // 
            this.bt_valider_search.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_valider_search.Enabled = false;
            this.bt_valider_search.Location = new System.Drawing.Point(59, 156);
            this.bt_valider_search.Name = "bt_valider_search";
            this.bt_valider_search.Size = new System.Drawing.Size(102, 23);
            this.bt_valider_search.TabIndex = 5;
            this.bt_valider_search.Text = "Valider";
            this.bt_valider_search.UseVisualStyleBackColor = true;
            // 
            // bt_annuler_search
            // 
            this.bt_annuler_search.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_annuler_search.Location = new System.Drawing.Point(228, 156);
            this.bt_annuler_search.Name = "bt_annuler_search";
            this.bt_annuler_search.Size = new System.Drawing.Size(102, 23);
            this.bt_annuler_search.TabIndex = 6;
            this.bt_annuler_search.Text = "Annuler";
            this.bt_annuler_search.UseVisualStyleBackColor = true;
            // 
            // tp_type
            // 
            this.tp_type.Controls.Add(this.cb_types);
            this.tp_type.Controls.Add(this.label3);
            this.tp_type.Location = new System.Drawing.Point(4, 22);
            this.tp_type.Name = "tp_type";
            this.tp_type.Size = new System.Drawing.Size(356, 101);
            this.tp_type.TabIndex = 2;
            this.tp_type.Text = "Type";
            this.tp_type.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type :";
            // 
            // cb_types
            // 
            this.cb_types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_types.FormattingEnabled = true;
            this.cb_types.Location = new System.Drawing.Point(140, 39);
            this.cb_types.Name = "cb_types";
            this.cb_types.Size = new System.Drawing.Size(135, 21);
            this.cb_types.TabIndex = 3;
            this.cb_types.SelectedIndexChanged += new System.EventHandler(this.cb_types_SelectedIndexChanged);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.bt_valider_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_annuler_search;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.bt_annuler_search);
            this.Controls.Add(this.bt_valider_search);
            this.Controls.Add(this.tc_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Rechercher";
            this.tc_search.ResumeLayout(false);
            this.tp_nom.ResumeLayout(false);
            this.tp_nom.PerformLayout();
            this.tp_sp.ResumeLayout(false);
            this.tp_sp.PerformLayout();
            this.tp_type.ResumeLayout(false);
            this.tp_type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_search;
        private System.Windows.Forms.TabPage tp_nom;
        private System.Windows.Forms.TabPage tp_sp;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_specialites;
        private System.Windows.Forms.Button bt_valider_search;
        private System.Windows.Forms.Button bt_annuler_search;
        private System.Windows.Forms.TabPage tp_type;
        private System.Windows.Forms.ComboBox cb_types;
        private System.Windows.Forms.Label label3;
    }
}