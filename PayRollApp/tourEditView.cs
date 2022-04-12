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
    public partial class tourEditView : Form
    {

        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        public string selectedCell = "1";

        public tourEditView()
        {
            InitializeComponent();
            populateList();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populateList()
        {
            DataTable userDetails = payrollDbConnection.getAllTours();
            tourData.DataSource = userDetails;
            tourData.RowHeadersVisible = false;
        }

        private void editTourBtn_Click(object sender, EventArgs e)
        {
            tourEditSpecificView tourEditSpecificView = new tourEditSpecificView(selectedCell);
            tourEditSpecificView.Show();
        }

        private void tourData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedCell = tourData.Rows[e.RowIndex].Cells[0].Value.ToString();            
        }
    }
}
