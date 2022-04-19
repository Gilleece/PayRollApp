using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace PayRollApp
{
    public partial class login : Form
    {
        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        public login()
        {
            if (File.Exists("payroll.db"))
            {
                InitializeComponent();
                passwordInput.PasswordChar = '*';
                DataTable userDetails = payrollDbConnection.getAllUserDetails();
                dataGridView.DataSource = userDetails;
                dataGridView.RowHeadersVisible = false;
            }
            else
            {
                var confirmUpdate = MessageBox.Show("The database is missing.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (userIDinput.Text == "" || passwordInput.Text == "")
            {
                MessageBox.Show("Please enter a userID and password.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
            else if (checkLoginDetails() == false)
            {
                MessageBox.Show("Incorrect Account Number or PIN. Please try again.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkAdmin() == true)
                {
                    adminView adminView = new adminView(userIDinput.Text);
                    MessageBox.Show("Successfully logged in as admin!",
                                         "Details Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userIDinput.Text = "";
                    passwordInput.Text = "";
                    adminView.Show();
                }
                else
                {
                    guideView guideView = new guideView(userIDinput.Text);
                    MessageBox.Show("Successfully logged in as guide!",
                                         "Details Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userIDinput.Text = "";
                    passwordInput.Text = "";
                    guideView.Show();
                }

            }
        }

        private bool checkLoginDetails()
        {
            bool isValid = payrollDbConnection.checkCredentials(userIDinput.Text, passwordInput.Text);
            return isValid;
        }

        private bool checkAdmin()
        {
            bool isAdmin = payrollDbConnection.checkIfAdmin(userIDinput.Text);
            return isAdmin;
        }
    }
}
