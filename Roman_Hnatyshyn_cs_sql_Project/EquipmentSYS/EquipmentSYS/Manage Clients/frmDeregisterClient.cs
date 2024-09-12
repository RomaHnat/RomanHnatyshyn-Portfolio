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
    public partial class frmDeregisterClient : Form
    {
        Client aClient = new Client();
        frmMainMenu parent;
        public frmDeregisterClient()
        {
            InitializeComponent();
        }

        public frmDeregisterClient(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
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
                }
                catch
                {
                  
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

        private void btnDeRegisterClient_Click(object sender, EventArgs e)
        {
            if (aClient.getStatus() == "A")
            {

                DialogResult result = MessageBox.Show("Do you want to DE-REGISTER client " + txtFirstName.Text + " " + txtSecondName.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("The Client has been de-registered.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aClient.setStatus("U");
                    aClient.updateClient(txtEmailAddress.Text);
                    grpClientDetails.Visible = false;
                    txtEmailAddress.Text = string.Empty;

                }

                    return;

            }

            else {

                DialogResult result = MessageBox.Show("Do you want to RESTORE client " + txtFirstName.Text + " " + txtSecondName.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("The Client has been restored.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aClient.setStatus("A");
                    aClient.updateClient(txtEmailAddress.Text);
                    grpClientDetails.Visible = false;
                    txtEmailAddress.Text = string.Empty;

                }

                return;

            }

        }

    }
}
