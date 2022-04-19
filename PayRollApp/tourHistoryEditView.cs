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
    public partial class tourHistoryEditView : Form
    {

        public dbConnector payrollDbConnection = new dbConnector(@"payroll.db");

        public string selectedCell = "1";

        public tourHistoryEditView()
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
            DataTable tourHistoryDataTable = payrollDbConnection.getAllTourHistory();
            tourData.DataSource = tourHistoryDataTable;
            tourData.RowHeadersVisible = false;
        }

        private void editTourBtn_Click(object sender, EventArgs e)
        {
            tourHistoryEditSpecificView tourHistoryEditSpecificView = new tourHistoryEditSpecificView(selectedCell, this);
            tourHistoryEditSpecificView.Show();
        }

        private void tourData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedCell = tourData.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void tourData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCell = tourData.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void addTourBtn_Click(object sender, EventArgs e)
        {
            addNewTourHistory addNewTourHistory = new addNewTourHistory(this);
            addNewTourHistory.Show();
         }
    }
}
