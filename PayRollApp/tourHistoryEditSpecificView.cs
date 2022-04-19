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
    public partial class tourHistoryEditSpecificView : Form
    {

        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        tourHistoryEditView originalForm;

        string thisSessionID;

        public tourHistoryEditSpecificView(string sessionID, tourHistoryEditView tourHistoryEditView)
        {
            InitializeComponent();
            thisSessionID = sessionID;
            populateFields(sessionID);
            originalForm = tourHistoryEditView;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populateFields(string sessionID)
        {
            DataTable tourHistoryDetails = payrollDbConnection.getSelectedTourHistory(sessionID);
            tourIDBox.Text = tourHistoryDetails.Rows[0][1].ToString();
            attenBox.Text = tourHistoryDetails.Rows[0][2].ToString();
            dayBox.Text = tourHistoryDetails.Rows[0][5].ToString();
            monthBox.Text = tourHistoryDetails.Rows[0][4].ToString();
            yearBox.Text = tourHistoryDetails.Rows[0][3].ToString();
            guideBox.Text = tourHistoryDetails.Rows[0][6].ToString();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            payrollDbConnection.updateSelectedTourHistory(thisSessionID, tourIDBox.Text, attenBox.Text, dayBox.Text, monthBox.Text, yearBox.Text, guideBox.Text);
            MessageBox.Show("Successfully updated!",
                                         "Absolutely incredible.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            originalForm.populateList();
            this.Close();
        }
    }
}
