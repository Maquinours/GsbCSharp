using System;
using System.Windows.Forms;

namespace ProjetGsbE5
{
    public partial class SearchForm : Form
    {
        private String searchText;

        public SearchForm()
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
