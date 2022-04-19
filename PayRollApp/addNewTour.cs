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
    public partial class addNewTour : Form
    {
        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        tourEditView originalForm;

        public addNewTour(tourEditView tourEditView)
        {
            InitializeComponent();
            originalForm = tourEditView;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (cityBox.Text == "" || priceBox.Text == "" || tier1Box.Text == "" || tier2Box.Text == "")
            {
                MessageBox.Show("No input fields can be empty.",
                                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tier1Box.Text.All(char.IsDigit) == false || tier2Box.Text.All(char.IsDigit) == false || priceBox.Text.All(char.IsDigit) == false || int.Parse(tier1Box.Text) < 1 || int.Parse(tier1Box.Text) > 99 || int.Parse(tier2Box.Text) < 1 || int.Parse(tier2Box.Text) > 99 || int.Parse(priceBox.Text) < 1 || int.Parse(priceBox.Text) > 99)
            {
                MessageBox.Show("Comission fields and price much contain 2 numbers ranging from 1 to 99");
            }
            else
            {
                payrollDbConnection.addNewTour(cityBox.Text, priceBox.Text, tier1Box.Text, tier2Box.Text);
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
