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

    }
}
