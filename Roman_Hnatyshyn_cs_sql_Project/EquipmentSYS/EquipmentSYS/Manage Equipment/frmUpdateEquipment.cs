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
    public partial class frmUpdateEquipment : Form
    {

        Equipment anEquipment = new Equipment();

        frmMainMenu parent;

        public frmUpdateEquipment()
        {
            InitializeComponent();
        }

        public frmUpdateEquipment(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategories.SelectedIndex == -1)
            {

                return;

            }

            comboBoxEquipment.Items.Clear();

            Utility.loadEquipmentDataUpdateEquipment(comboBoxEquipment, comboBoxCategories.Text.Substring(0, 2));

            comboBoxEquipment.Visible = true;
            label2.Visible = true;
            grpEquipment.Visible = false;
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {

            String rateString = txtEquipmentRate.Text;
            float rate;

            bool rateTry = float.TryParse(rateString, out rate);

            if (comboBoxNewCategories.SelectedIndex == -1)
            {

                MessageBox.Show("You did not select the category", "Invalid Category!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtEquipmentName.Text.All(t => char.IsDigit(t)) || txtEquipmentName.Text.Equals(""))
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

            if (txtEquipmentDescription.Text.All(t => char.IsDigit(t)) || txtEquipmentDescription.Text.Equals(""))
            {

                MessageBox.Show("Invalid Description entered. Description cannot be numeric.", "Invalid Description!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEquipmentDescription.Focus();
                return;
            }

            if (!rateTry || rate <= 0 || rate > 1000)
            {

                MessageBox.Show("Invalid Rate entered. Must be numeric, greater than 0 and less than 1000.", "Invalid Rate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEquipmentRate.Focus();
                return;
            }

                MessageBox.Show("Equipment has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            anEquipment.setEqName(txtEquipmentName.Text);
            anEquipment.setSerialNumber(txtSerialNumber.Text);
            anEquipment.setDescription(txtEquipmentDescription.Text);
            anEquipment.setRate(decimal.Parse(txtEquipmentRate.Text));
            anEquipment.setCategoryID(comboBoxNewCategories.Text.Substring(0, 2));

            anEquipment.updateEquipment(Convert.ToInt32(comboBoxEquipment.Text.Substring(0, 6)));

                txtEquipmentName.Text = string.Empty;
                txtSerialNumber.Text = string.Empty;
                txtEquipmentDescription.Text = string.Empty;
                txtEquipmentRate.Text = string.Empty;
                comboBoxNewCategories.SelectedIndex = -1;
                comboBoxEquipment.SelectedIndex = -1;
                comboBoxCategories.SelectedIndex = -1;
                grpEquipment.Visible = false;
                comboBoxEquipment.Visible = false;
                label2.Visible = false;
            

        }

        private void comboBoxEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEquipment.SelectedIndex != -1)
            {
                anEquipment.getEquipment(Convert.ToInt32(comboBoxEquipment.Text.Substring(0, 6)));

                txtEquipmentName.Text = anEquipment.getEqName();
                txtEquipmentDescription.Text = anEquipment.getDescription();
                txtSerialNumber.Text = anEquipment.getSerialNumber();
                txtEquipmentRate.Text = anEquipment.getRate().ToString();

                comboBoxNewCategories.Items.Clear();

                Utility.loadCategoryData(comboBoxNewCategories);
                comboBoxNewCategories.SelectedIndex = comboBoxCategories.SelectedIndex;

                grpEquipment.Visible = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            parent.Visible = true;

        }

        private void frmUpdateEquipment_Load(object sender, EventArgs e)
        {
            Utility.loadCategoryData(comboBoxCategories);
        }
    }
}
