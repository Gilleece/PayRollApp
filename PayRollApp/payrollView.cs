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
    public partial class payrollView : Form
    {

        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        public payrollView()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            if (payrollDbConnection.checkIfUserExists(userID.Value.ToString()))
            {
                generatedPayroll generatedPayroll = new generatedPayroll(userID.Value.ToString(), year.Value.ToString(), month.Value.ToString());
                generatedPayroll.Show();
            }
            else
            {
                MessageBox.Show("User doesn't exist.",
                                             "Oh my.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
