using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollApp
{
    public partial class generatedPayroll : Form
    {

        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        public generatedPayroll(string userID, string year, string month)
        {
            InitializeComponent();
            DataTable userDetails = payrollDbConnection.getPayrollTours(userID, year, month);
            tourHistoryView.DataSource = userDetails;
            tourHistoryView.RowHeadersVisible = false;
            nameLabel.Text = payrollDbConnection.getName(userID);
            userIDLabel.Text = userID;
            monthLabel.Text = month;
            yearLabel.Text = year;
            commisionLabel.Text = payrollDbConnection.getComission(userID, year, month).ToString();
            if (commisionLabel.Text == "0")
            {
                MessageBox.Show("No tours for this query.",
                                             "You're broke.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing now...(this is placeholder for testing purposes)",
                                             "Printing now. Absolutely.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
