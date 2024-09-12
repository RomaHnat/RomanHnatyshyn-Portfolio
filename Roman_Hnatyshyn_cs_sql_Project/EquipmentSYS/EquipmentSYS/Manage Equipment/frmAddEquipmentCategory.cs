using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EquipmentSYS
{
    public partial class frmAddEquipmentCategory : Form
    {

        frmMainMenu parent;

        public frmAddEquipmentCategory()
        {
            InitializeComponent();
        }

        public frmAddEquipmentCategory(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {

            bool containsOnlyLetters = txtCategoryID.Text.All(t => char.IsUpper(t));

            if (txtCategoryID.TextLength != 2 || !containsOnlyLetters) {

                MessageBox.Show("Invalid Category ID entered. Must contain 2 capital letters only.", "Invalid Category ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryID.Focus();
                return;
            }

            if (txtCategoryName.Text.All(t => char.IsDigit(t)))
            {

                MessageBox.Show("Invalid Category Name entered. Name cannot be numeric.", "Invalid Name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
                return;
            }

            if (txtCategoryDescription.Text.All(t => char.IsDigit(t))) {

                MessageBox.Show("Invalid Description entered. Description cannot be numeric.", "Invalid Description!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryDescription.Focus();
                return;
            }

            try
            {
                Category aCategory = new Category(txtCategoryID.Text, txtCategoryName.Text, txtCategoryDescription.Text);

                aCategory.addCategory();

                //display confirmation message
                MessageBox.Show("Category " + txtCategoryID.Text + " (" + txtCategoryName.Text + ") added successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtCategoryDescription.Text = string.Empty;
                txtCategoryID.Text = string.Empty;
                txtCategoryName.Text = string.Empty;

            }
            catch (OracleException ex) {

                if (ex.Number == 1) {

                    MessageBox.Show("CategoryID must be unique.", "Invalid Category ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoryID.Focus();

                }
            
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
            
        }
    }
}
