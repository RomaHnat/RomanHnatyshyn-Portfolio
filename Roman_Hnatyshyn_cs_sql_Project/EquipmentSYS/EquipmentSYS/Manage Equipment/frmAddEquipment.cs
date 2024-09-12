using Oracle.ManagedDataAccess.Client;
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
    public partial class frmAddEquipment : Form
    {

        frmMainMenu parent;

        public frmAddEquipment()
        {
            InitializeComponent();
        }

        public frmAddEquipment(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {

            String rateString = txtEquipmentRate.Text;
            float rate;

            bool rateTry = float.TryParse(rateString, out rate);


            if (comboBoxCategories.SelectedIndex == -1) {

                MessageBox.Show("You did not select the category", "Invalid Category!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtEquipmentName.Text.All(t => char.IsDigit(t)))
            {

                MessageBox.Show("Invalid Equipment Name entered. Name cannot be numeric.", "Invalid Name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEquipmentName.Focus();
                return;
            }

            if (txtSerialNumber.Text.Equals(""))
            {

                MessageBox.Show("Invalid Serial Number entered. Serial Number cannot be empty.", "Invalid Serial Number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSerialNumber.Focus();
                return;
            }

            if (txtEquipmentDescription.Text.All(t => char.IsDigit(t)))
            {

                MessageBox.Show("Invalid Description entered. Description cannot be numeric.", "Invalid Description!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEquipmentDescription.Focus();
                return;
            }

            if (!rateTry || rate<=0 || rate>1000)
            {

                MessageBox.Show("Invalid Rate entered. Must be numeric greater than 0 and less that 1000.", "Invalid Rate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEquipmentRate.Focus();
                return;
            }
            
                MessageBox.Show("New Equipment " + txtEquipmentName.Text + " has been added with rate " + rate + ".", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                String selectedItem = comboBoxCategories.SelectedItem.ToString();
                String catId = selectedItem.Substring(0, 2);

                Equipment anEquipment = new Equipment(Equipment.getNextEquipmentID(), txtEquipmentName.Text, txtSerialNumber.Text, txtEquipmentDescription.Text, Convert.ToDecimal(txtEquipmentRate.Text), catId);

                anEquipment.addEquipment();

                txtEquipmentName.Text = string.Empty;
                txtSerialNumber.Text = string.Empty;
                txtEquipmentDescription.Text = string.Empty;
                txtEquipmentRate.Text = string.Empty;
                comboBoxCategories.SelectedIndex = -1;

        }

        private void frmAddEquipment_Load(object sender, EventArgs e)
        {
            Utility.loadCategoryData(comboBoxCategories);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            parent.Visible = true;

        }
    }
}
