using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentSYS
{
    public partial class frmPlaceRental : Form
    {
        frmMainMenu parent;

        decimal price = 0;

        Client aClient = new Client();

        Equipment anEquipment = new Equipment();

        List<String> equipmentsToRent = new List<String>();

        public frmPlaceRental()
        {
            InitializeComponent();
        }

        public frmPlaceRental(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmPlaceRental_Load(object sender, EventArgs e)
        {
            txtCart.Clear();
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today.AddDays(1);
            dateTimePicker1.MinDate = DateTime.Today.AddDays(1);
            Utility.loadCategoryData(comboBoxCategories);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategories.SelectedIndex == -1)
            {

                return;

            }

            comboBoxEquipment.Items.Clear();

            DateTime returnDate = DateTime.Parse(String.Format("{0:dd-MMM-yy}", dateTimePicker1.Value));
            DateTime collectionDate = DateTime.Parse(String.Format("{0:dd-MMM-yy}", dateTimePicker2.Value));

            Utility.loadEquipmentDataPlaceRental(comboBoxEquipment, comboBoxCategories.Text.Substring(0, 2), collectionDate, returnDate);

            comboBoxEquipment.Visible = true;
            label3.Visible = true;
        }

        private void comboBoxEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnAddToCart.Visible = true;

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            if (dateTimePicker2.Value >= dateTimePicker1.Value)
            {
                MessageBox.Show("Date To must be after Date From", "Invalid Date!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            String pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (txtEmailAddress.Text.Equals("") || Regex.IsMatch(txtEmailAddress.Text, pattern) != true)
            {

                MessageBox.Show("Invalid email address entered", "Invalid Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!txtEmailAddress.Text.Equals(""))
            {
                try
                {

                    aClient.getClient(txtEmailAddress.Text);

                    if (aClient.getStatus() == "U") {

                        MessageBox.Show("The client selected is UNACTIVE", "Invalid Client!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmailAddress.Focus();
                        return;

                    }

                    int clientID = aClient.getClientID();

                }
                catch
                {

                    txtEmailAddress.Focus();
                    MessageBox.Show("Invalid Email entered. Email does not exist.", "Invalid Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }

            if(comboBoxEquipment.Text.Equals(""))
            {
                MessageBox.Show("You must select an equipment", "Invalid Equipment!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

           if (!IsNotInCart(equipmentsToRent, comboBoxEquipment.Text.Substring(0, 6)))
            {

                MessageBox.Show("You have this equipment selected already", "Invalid Equipment!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

                anEquipment.getEquipment(Convert.ToInt32(comboBoxEquipment.Text.Substring(0, 6)));

                TimeSpan duration = dateTimePicker1.Value - dateTimePicker2.Value;
                double durationInDays = duration.TotalDays;

                price += anEquipment.getRate() * decimal.Parse(durationInDays.ToString());

                equipmentsToRent.Add(comboBoxEquipment.Text.Substring(0, 6));

                grpCart.Visible = true;
                txtCart.Text += comboBoxEquipment.SelectedItem.ToString().Substring(8) + "\n\n";
                comboBoxCategories.SelectedIndex = -1;
                label3.Visible = false;
                comboBoxEquipment.SelectedIndex = -1;
                comboBoxEquipment.Visible = false;
                btnAddToCart.Visible = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                txtEmailAddress.Enabled = false;
                labelTotal.Text = price.ToString();

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            int clientID = aClient.getClientID();

            int actualRentID = Rental.getNextRentalID();

            DateTime returnDate = DateTime.Parse(String.Format("{0:dd-MMM-yy}", dateTimePicker1.Value));
            DateTime collectionDate = DateTime.Parse(String.Format("{0:dd-MMM-yy}", dateTimePicker2.Value));

            Rental aRental = new Rental(actualRentID, collectionDate, returnDate,  price, "A", clientID);

            aRental.addRental();

            RentalItem rentalItem = new RentalItem();

            foreach (var item in equipmentsToRent) { 

                rentalItem.setRentalID(actualRentID);
                rentalItem.setEquipmentID(int.Parse(item));
                rentalItem.setPricePerEq(0);

                rentalItem.addRentalItem();

            }

            MessageBox.Show("Rental with ID "  + actualRentID.ToString().PadLeft(6, '0') + " has been placed. Price of the rental is " + price.ToString() + " Euro.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            try
            {

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("equipmentrentalsys@gmail.com", "Equipment123!"),
                    EnableSsl = true
                };

                smtpClient.Send("equipmentrentalsys@gmail.com", txtEmailAddress.Text, "New Rental!", "Hello,\n\nYour RentalID is "
                    + actualRentID.ToString().PadLeft(6, '0')
                    + ".\nYour collection date is "
                    + collectionDate.ToString("dd-MMM-yyyy")
                    + " and return date is "
                    + returnDate.ToString("dd-MMM-yyyy")
                    + ".\n\nThank you for choosing us!\n\nRegards,\nEquipment Rental Team.");

            } catch {

                MessageBox.Show("Unable to send a confirmation email. Please check your port security settings", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            grpCart.Visible = false;
            comboBoxCategories.SelectedIndex = -1;
            label3.Visible = false;
            comboBoxEquipment.SelectedIndex = -1;
            comboBoxEquipment.Visible = false;
            btnAddToCart.Visible = false;
            price = 0;
            txtCart.Clear();
            txtEmailAddress.Clear();
            txtEmailAddress.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;

            equipmentsToRent.Clear();

            //smtpClient.Send("equipmentrentalsys@gmail.com", txtEmailAddress.Text, "New Rental!", "Hello, \n Your RentalID is " );

        }

        private static bool IsNotInCart(List<String> equipmentsToRent, String selectedEquipment) {


            if (equipmentsToRent.Contains(selectedEquipment))
            {

                return false;

            }            
        
            return true;

        }

    }
}
