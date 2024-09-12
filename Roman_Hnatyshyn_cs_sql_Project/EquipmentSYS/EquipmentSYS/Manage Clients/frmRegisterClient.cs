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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EquipmentSYS
{
    public partial class frmRegisterClient : Form
    {



        frmMainMenu parent;

        public frmRegisterClient()
        {
            InitializeComponent();
        }

        public frmRegisterClient(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
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

            if (txtEmailAddress.Text.Equals("") || Regex.IsMatch(txtEmailAddress.Text, pattern)!=true)
            {

                MessageBox.Show("Invalid email address entered. Invalid format.", "Invalid Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }

            try
            {

                Client aClient = new Client(Client.getNextClientID(), txtFirstName.Text, txtSecondName.Text, txtMobileNumber.Text, txtEmailAddress.Text, "A");

                aClient.addClient();

                MessageBox.Show("New client " + txtFirstName.Text + " " + txtSecondName.Text + " has been registered.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFirstName.Text = string.Empty;
                txtSecondName.Text = string.Empty;
                txtMobileNumber.Text = string.Empty;
                txtEmailAddress.Text = string.Empty;
            }
            catch (OracleException ex) {

                if (ex.Number == 1)
                {

                    MessageBox.Show("Email is already registered in the system.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Focus();

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
