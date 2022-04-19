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
    public partial class addNewTourHistory : Form
    {
        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        tourHistoryEditView originalForm;

        public addNewTourHistory(tourHistoryEditView tourHistoryEditView)
        {
            InitializeComponent();
            originalForm = tourHistoryEditView;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (tourIDBox.Text == "" || attenBox.Text == "" || dayBox.Text == "" || monthBox.Text == "" || yearBox.Text == "" || guideBox.Text == "")
            {
                MessageBox.Show("No input fields can be empty.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tourIDBox.Text.All(char.IsDigit) == false || attenBox.Text.All(char.IsDigit) == false || dayBox.Text.All(char.IsDigit) == false || monthBox.Text.All(char.IsDigit) == false || yearBox.Text.All(char.IsDigit) == false || guideBox.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("All inputs fields are numeric only");
            }
            else
            {
                payrollDbConnection.addNewTourHistory(tourIDBox.Text, attenBox.Text, dayBox.Text, monthBox.Text, yearBox.Text, guideBox.Text);
                MessageBox.Show("Successfully updated!",
                                             "Absolutely incredible.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                originalForm.populateList();
                this.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
