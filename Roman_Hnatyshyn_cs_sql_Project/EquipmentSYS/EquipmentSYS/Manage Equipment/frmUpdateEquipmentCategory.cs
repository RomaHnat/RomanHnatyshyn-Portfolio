using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EquipmentSYS
{
    public partial class frmUpdateEquipmentCategory : Form
    {

        frmMainMenu parent;

        Category aCategory = new Category();

        public frmUpdateEquipmentCategory()
        {
            InitializeComponent();
        }

        public frmUpdateEquipmentCategory(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategories.SelectedIndex != -1)
            {
                String selectedItem = comboBoxCategories.SelectedItem.ToString();
                String id = selectedItem.Substring(0, 2);

                aCategory.getCategory(id);

                txtCategoryID.Text = aCategory.getCategoryID();
                txtCategoryName.Text = aCategory.getCatName();
                txtCategoryDescription.Text = aCategory.getCatDescription();

                grpEquipmentCategories.Visible = true;
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            bool containsOnlyLetters = txtCategoryID.Text.All(t => char.IsUpper(t));

            if (txtCategoryID.TextLength != 2 || !containsOnlyLetters)
            {

                MessageBox.Show("Invalid Category ID entered. Must contain only 2 capital letters.", "Invalid Category ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryID.Focus();
                return;

            }

            if (txtCategoryName.Text.All(t => char.IsDigit(t)))
            {

                MessageBox.Show("Invalid Category Name entered. Name cannot be numeric.", "Invalid Name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
                return;

            }

            if (txtCategoryDescription.Text.All(t => char.IsDigit(t)))
            {

                MessageBox.Show("Invalid Description entered. Description cannot be numeric.", "Invalid Description!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryDescription.Focus();
                return;

            }
                

            try
            {
                String selectedItem = comboBoxCategories.SelectedItem.ToString();
                String id = selectedItem.Substring(0, 2);
                aCategory.setCategoryID(txtCategoryID.Text);
                aCategory.setCatName(txtCategoryName.Text);
                aCategory.setCatDescription(txtCategoryDescription.Text);

                aCategory.updateCategory(id);

                MessageBox.Show("Equipment Category has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grpEquipmentCategories.Visible = false;

                comboBoxCategories.SelectedIndex = -1;

                comboBoxCategories.Items.Clear();

                Utility.loadCategoryData(comboBoxCategories);

            }
            catch (OracleException ex)
            {

                if (ex.Number == 1)
                {

                    MessageBox.Show("CategoryID must be unique.", "Invalid CategoryID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoryID.Focus();
                }

            }
      
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateEquipmentCategory_Load(object sender, EventArgs e)
        {
            Utility.loadCategoryData(comboBoxCategories);
        }
    }
}

