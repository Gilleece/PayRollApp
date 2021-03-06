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

        public void populateList()
        {
            DataTable tourDataTable = payrollDbConnection.getAllTours();
            tourData.DataSource = tourDataTable;
            tourData.RowHeadersVisible = false;
        }

        private void editTourBtn_Click(object sender, EventArgs e)
        {
            tourEditSpecificView tourEditSpecificView = new tourEditSpecificView(selectedCell, this);
            tourEditSpecificView.Show();
        }

        private void tourData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedCell = tourData.Rows[e.RowIndex].Cells[0].Value.ToString();            
        }

        private void addTourBtn_Click(object sender, EventArgs e)
        {
            addNewTour addNewTour = new addNewTour(this);
            addNewTour.Show();
        }
    }
}
