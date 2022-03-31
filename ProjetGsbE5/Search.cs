using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGsbE5
{
    public partial class Search : Form
    {
        private String searchText;

        public Search()
        {
            InitializeComponent();
        }

        public string SearchText { get => searchText; }

        private void bt_rechercher_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.searchText = tb_rechercher.Text;
            this.Close();
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        } 
    }
}
