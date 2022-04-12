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
    public partial class tourEditSpecificView : Form
    {

        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        public tourEditSpecificView(string tourID)
        {
            InitializeComponent();
            populateFields(tourID);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populateFields(string tourID)
        {
            DataTable tourDetails = payrollDbConnection.getSelectedTour(tourID);
            tourIDBox.Text = tourDetails.Rows[0][0].ToString();
            cityBox.Text = tourDetails.Rows[0][1].ToString();
            priceBox.Text = tourDetails.Rows[0][2].ToString();
            tier1Box.Text = tourDetails.Rows[0][3].ToString();
            tier2Box.Text = tourDetails.Rows[0][4].ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
