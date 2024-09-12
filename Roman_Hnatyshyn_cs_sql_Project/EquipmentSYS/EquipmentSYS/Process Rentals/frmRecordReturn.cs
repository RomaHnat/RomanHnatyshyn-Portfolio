using EquipmentSYS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EquipmentSYS
{
    public partial class frmRecordReturn : Form
    {
        Rental aRental = new Rental();
        RentalItem aRentalItem = new RentalItem();
        Equipment anEquipment = new Equipment();    

        frmMainMenu parent;
        public frmRecordReturn()
        {
            InitializeComponent();
        }

        public frmRecordReturn(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void txtRentalID_TextChanged(object sender, EventArgs e)
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
                }

                catch
                {

                    MessageBox.Show("Rental with the ID does not exist", "Invalid RentalID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                Utility.loadAllRentalItemsCmb(comboBoxEquipmentInRental, int.Parse(txtRentalID.Text));
                comboBoxEquipmentInRental.Items.Add("Return All");

            }

            else
            {

                MessageBox.Show("Invalid RentalID entered", "Invalid RentalID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (aRental.getStatus() == "A")
            {

                MessageBox.Show("Rental with the ID entered is not collected yet.", "Invalid Status!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (aRental.getStatus() == "R")
            {

                MessageBox.Show("Rental with the ID entered is alredy returned.", "Invalid Status!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            grpRentalDetails.Visible = true;

        }
   

        private void btnRecordReturn_Click(object sender, EventArgs e)
        {

            if (comboBoxEquipmentInRental.SelectedIndex == -1) {

                MessageBox.Show("You did not select equipment you are returning.", "Invalid Equipment!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            } 

            aRental.getRental(int.Parse(txtRentalID.Text));

            if (comboBoxEquipmentInRental.Text!= "Return All")
            {

                anEquipment.getEquipment(Convert.ToInt32(comboBoxEquipmentInRental.Text.Substring(0, 6)));
                DateTime today = DateTime.Today;

                TimeSpan duration;

                if (today > aRental.getReturnDate())
                {

                    duration = today - aRental.getCollectionDate();

                }

                else {

                    duration = aRental.getReturnDate() - aRental.getCollectionDate();

                }

                double durationInDays = duration.TotalDays;
                double price = (double)(anEquipment.getRate() * decimal.Parse(durationInDays.ToString()));

                aRentalItem.setPricePerEq(price);
                aRentalItem.setActualReturnDate(today);

                aRentalItem.updateRentalItem(aRental.getRentalID(), Convert.ToInt32(comboBoxEquipmentInRental.Text.Substring(0, 6)));

                MessageBox.Show("Equipment " + anEquipment.getEqName() + " - " + anEquipment.getSerialNumber() + " in rental with ID " + aRental.getRentalID().ToString().PadLeft(6, '0') + " has been returned.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (comboBoxEquipmentInRental.Items.Count == 2) {

                    MessageBox.Show("All the equipment in rental with ID " + aRental.getRentalID().ToString().PadLeft(6, '0') + " has been returned.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    decimal newPrice = aRentalItem.getNewRentalPrice(int.Parse(txtRentalID.Text));
                    
                    aRental.setStatus("R");
                    aRental.setPrice(newPrice);
                    aRental.updateRental();

                }
            
            }

            else {

                int itemCount = comboBoxEquipmentInRental.Items.Count;
                for (int i = 0; i < itemCount - 1; i++)
                {
                    String item = comboBoxEquipmentInRental.Items[i].ToString();
                    anEquipment.getEquipment(Convert.ToInt32(item.Substring(0, 6)));

                    DateTime today = DateTime.Today;

                    TimeSpan duration;

                    if (today > aRental.getReturnDate())
                    {

                        duration = today - aRental.getCollectionDate();

                    }

                    else
                    {

                        duration = aRental.getReturnDate() - aRental.getCollectionDate();

                    }

                    double durationInDays = duration.TotalDays;
                    double price = (double)(anEquipment.getRate() * decimal.Parse(durationInDays.ToString()));

                    aRentalItem.setPricePerEq(price);
                    aRentalItem.setActualReturnDate(today);

                    aRentalItem.updateRentalItem(aRental.getRentalID(), Convert.ToInt32(item.Substring(0, 6)));

                    decimal newPrice = aRentalItem.getNewRentalPrice(int.Parse(txtRentalID.Text));

                    aRental.setStatus("R");
                    aRental.setPrice(newPrice);
                    aRental.updateRental();

                }

                MessageBox.Show("All the equipment in rental with ID " + aRental.getRentalID().ToString().PadLeft(6, '0') + " has been returned.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            grpRentalDetails.Visible = false;
            comboBoxEquipmentInRental.Items.Clear();
            txtRentalID.Clear();

        }

        private void frmRecordReturn_Load(object sender, EventArgs e)
        {
            comboBoxEquipmentInRental.Items.Clear();
        }
    }
}
