using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace ProjetGsbE5
{
    public partial class SpecialitesForm : Form
    {
        private long _idPraticien;
        public SpecialitesForm(long praticienId, string praticienFirstName, string praticienLastName)
        {
            this._idPraticien = praticienId;
            InitializeComponent();

            LoadSpecialites();
        }

        private void LoadSpecialites()
        {
            try
            {
                foreach (DataRow dr in DbDialog.GetSpecialitesPraticien(this._idPraticien).Rows)
                {
                    dgv_specialite.Rows.Add(dr["id_specialite"], dr["lib_specialite"], dr["diplome"], dr["coef_prescription"]);
                }
            } catch { throw; }
        }
    }
}
