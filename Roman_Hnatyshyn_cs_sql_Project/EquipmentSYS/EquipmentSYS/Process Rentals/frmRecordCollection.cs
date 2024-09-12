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
    public partial class frmRecordCollection : Form
    {
        Rental aRental = new Rental();
        RentalItem aRentalItem = new RentalItem();

        frmMainMenu parent;

        public frmRecordCollection()
        {
            InitializeComponent();
        }

        public frmRecordCollection(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRecordCollection_Click(object sender, EventArgs e)
        {

            aRental.getRental(int.Parse(txtRentalID.Text));

            if (aRental.getStatus() == "C") {

                MessageBox.Show("Rental with the ID entered is already collected.", "Invalid Status!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            DateTime collectionDate = aRental.getCollectionDate();
            DateTime today = DateTime.Today;

            if (collectionDate > today) {

                MessageBox.Show("It is too early to collect the Rental with the ID entered.", "Invalid Date!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (aRental.getStatus() == "A")
            {
               try
               {

                    aRental.setStatus("C");
                    aRental.updateRental();
                    MessageBox.Show("The Rental with ID entered is now COLLECTED.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRentalID.Clear();
                    
                 }
                 catch {

                    MessageBox.Show("Something went wrong. Try again.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            grpRentalDetails.Visible = false;
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

                catch
                {

                    MessageBox.Show("Rental with the ID does not exist", "Invalid RentalID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

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
