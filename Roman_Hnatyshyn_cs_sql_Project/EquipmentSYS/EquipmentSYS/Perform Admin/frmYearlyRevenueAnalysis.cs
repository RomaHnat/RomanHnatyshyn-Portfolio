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
    public partial class frmYearlyRevenueAnalysis : Form
    {

        frmMainMenu parent;

        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        public frmYearlyRevenueAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {

            Utility.fillYearsComboBox(comboBoxYear);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYear.SelectedIndex!=-1) {

                grpYearlyRevenue.Visible = true;

                chrRevenue.Series[0].Points.Clear();
                chrRevenue.Titles.Clear();

                int year = int.Parse(comboBoxYear.SelectedItem.ToString());

                Admin.yearlyRevenue(chrRevenue, year);


            }
        }

        private void btnOkYearlyRevenueAnalysis_Click(object sender, EventArgs e)
        {
            grpYearlyRevenue.Visible = false;
            comboBoxYear.SelectedIndex = -1;
        }
    }
}
