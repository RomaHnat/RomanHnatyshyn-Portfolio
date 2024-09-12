using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentSYS
{
    public partial class frmAnalyseCategoryProfit : Form
    {
        frmMainMenu parent;

        public frmAnalyseCategoryProfit()
        {
            InitializeComponent();
        }

        public frmAnalyseCategoryProfit(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYear.SelectedIndex != -1)
            {
                int year = int.Parse(comboBoxYear.SelectedItem.ToString());

                Admin.categoryProfit(txtReport, year);

                grpEquipmentProfit.Visible = true;

            }
        }

        private void btnOkYearlyRevenueAnalysis_Click(object sender, EventArgs e)
        {
            grpEquipmentProfit.Visible = false;
            comboBoxYear.SelectedIndex = -1;
        }

        private void frmAnalyseCategoryProfit_Load(object sender, EventArgs e)
        {
            Utility.fillYearsComboBox(comboBoxYear);
        }

    }
}
