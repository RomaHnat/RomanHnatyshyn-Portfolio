using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace EquipmentSYS
{
    public partial class frmMainMenu : Form
    {

        OracleConnection conn = new OracleConnection(DBConnect.oraDB);

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void manageEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

        }

        private void addEquipmentCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAddEquipmentCategory nextForm = new frmAddEquipmentCategory(this);
            this.Hide();
            nextForm.Show();
        }

        private void updateEquipmentCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmUpdateEquipmentCategory nextForm = new frmUpdateEquipmentCategory(this);
            this.Hide();
            nextForm.Show();
        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAddEquipment nextForm = new frmAddEquipment(this);
            this.Hide();
            nextForm.Show(this);
        }

        private void updateEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmUpdateEquipment nextForm = new frmUpdateEquipment(this);
            this.Hide();
            nextForm.Show();
        }

        private void registerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmRegisterClient nextForm = new frmRegisterClient(this);
            this.Hide();
            nextForm.Show();
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateClient nextForm = new frmUpdateClient(this);
            this.Hide();
            nextForm.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearlyRevenueAnalysis nextForm = new frmYearlyRevenueAnalysis(this);
            this.Hide();
            nextForm.Show();
        }

        private void placeRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlaceRental nextForm = new frmPlaceRental(this);
            this.Hide();
            nextForm.Show();
        }

        private void cancelRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelRental nextForm = new frmCancelRental(this);
            this.Hide();
            nextForm.Show();
        }

        private void recordCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecordCollection nextForm = new frmRecordCollection(this);
            this.Hide();
            nextForm.Show();
        }

        private void recordReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecordReturn nextForm = new frmRecordReturn(this);
            this.Hide();
            nextForm.Show();
        }

        private void deRegisterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeregisterClient nextForm = new frmDeregisterClient(this);
            this.Hide();
            nextForm.Show();
        }

        private void analyseCategoryProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnalyseCategoryProfit nextForm = new frmAnalyseCategoryProfit(this);
            this.Hide();
            nextForm.Show();
        }
        
    }
}
