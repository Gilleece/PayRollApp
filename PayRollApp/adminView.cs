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
    public partial class adminView : Form
    {
        public adminView(string userID)
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTourBtn_Click(object sender, EventArgs e)
        {
            tourEditView tourEditView = new tourEditView();
            tourEditView.Show();
        }

        private void editTourHistoryBtn_Click(object sender, EventArgs e)
        {
            tourHistoryEditView tourHistoryEditView = new tourHistoryEditView();
            tourHistoryEditView.Show();
        }

        private void PayrollBtn_Click(object sender, EventArgs e)
        {
            payrollView payrollView = new payrollView();
            payrollView.Show();
        }
    }
}
