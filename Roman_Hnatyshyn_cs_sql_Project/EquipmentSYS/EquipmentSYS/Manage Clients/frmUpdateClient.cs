using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentSYS
{
    public partial class frmUpdateClient : Form
    {

        Client aClient = new Client();
        frmMainMenu parent;

        public frmUpdateClient()
        {
            InitializeComponent();
        }

        public frmUpdateClient(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text.All(t => char.IsDigit(t)) || txtFirstName.Text.Equals(""))
            {

                MessageBox.Show("Invalid first name entered. First name cannot be empty or numeric.", "Invalid Name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (txtSecondName.Text.All(t => char.IsDigit(t)) || txtSecondName.Text.Equals(""))
            {

                MessageBox.Show("Invalid second name entered. Second name cannot be empty or numeric.", "Invalid Name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecondName.Focus();
                return;
            }

            if (!txtMobileNumber.Text.All(t => char.IsDigit(t)) || txtMobileNumber.Text.Equals(""))
            {

                MessageBox.Show("Invalid mobile number entered. Mobile number must be numeric.", "Invalid Mobile Number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobileNumber.Focus();
                return;
            }

            String pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (txtNewEmailAddress.Text.Equals("") || Regex.IsMatch(txtEmailAddress.Text, pattern) != true)
            {

                MessageBox.Show("Invalid email address entered. Invalid format.", "Invalid Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }

            try
            { 

                aClient.setFirstName(txtFirstName.Text);
                aClient.setSecondName(txtSecondName.Text);
                aClient.setEmail(txtNewEmailAddress.Text);
                aClient.setMobileNumber(txtMobileNumber.Text);
                aClient.setStatus("A");

                aClient.updateClient(txtEmailAddress.Text);

                MessageBox.Show("Client " + txtFirstName.Text + " " + txtSecondName.Text + " has updated his profile", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFirstName.Text = string.Empty;
                txtSecondName.Text = string.Empty;
                txtMobileNumber.Text = string.Empty;
                txtNewEmailAddress.Text = string.Empty;
                grpClientDetails.Visible = false;
                txtEmailAddress.Text = string.Empty;
            }
            catch (OracleException ex)
            {

                if (ex.Number == 1)
                {

                    MessageBox.Show("Email is already registered in the system.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Focus();

                }

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtEmailAddress.Text.Equals(""))
            {
                try
                {
                    aClient.getClient(txtEmailAddress.Text);

                    txtFirstName.Text = aClient.getFirstName();
                    txtSecondName.Text = aClient.getSecondName();
                    txtMobileNumber.Text = aClient.getMobileNumber();
                    txtNewEmailAddress.Text = aClient.getEmail();

                    grpClientDetails.Visible = true;
                } catch {

                    txtEmailAddress.Focus();
                    MessageBox.Show("Invalid Email entered. Email does not exist.", "Invalid Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {

                MessageBox.Show("Invalid Email entered. Invalid format.", "Invalid Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            grpClientDetails.Visible = false;
        }
    }
}
