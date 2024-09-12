using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentSYS
{
    public partial class frmCancelRental : Form
    {

        Rental aRental = new Rental();
        RentalItem aRentalItem = new RentalItem(); 

        frmMainMenu parent;

        public frmCancelRental()
        {
            InitializeComponent();
        }

        public frmCancelRental(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void comboBoxRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            DateTime collectionDate = aRental.getCollectionDate();
            DateTime today = DateTime.Today;

            if (collectionDate > today)
            {
                MessageBox.Show("Rental with ID " + aRental.getRentalID().ToString().PadLeft(6, '0') + " has been canceled.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                aRentalItem.deleteRentalItems(int.Parse(txtRentalID.Text));
                aRental.cancelRental();

                grpRentalDetails.Visible = false;
                txtRentalID.Text = string.Empty;
            }

            else {

                MessageBox.Show("It is too late to cancel (Collection date has been lasted).", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtRentalID.Text.Equals(string.Empty) && txtRentalID.Text.All(t => char.IsDigit(t)) && txtRentalID.Text.Length == 6)
            {
                try
                {
                    aRental.getRental(int.Parse(txtRentalID.Text));
                    txtDateRange.Text = aRental.getCollectionDate().ToString().Substring(0, 10) + " - " + aRental.getReturnDate().ToString().Substring(0, 10);
                    txtPrice.Text = aRental.getPrice().ToString();

                    grpRentalDetails.Visible = true;
                }

                catch {

                    MessageBox.Show("Rental with the ID does not exist", "Invalid RentalID!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Utility.loadAllRentalItemsCart(txtEquipmentInRental, int.Parse(txtRentalID.Text));

            }

            else
            {

                MessageBox.Show("Invalid RentalID entered", "Invalid RentalID!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
