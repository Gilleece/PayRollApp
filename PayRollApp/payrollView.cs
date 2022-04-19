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
            generatedPayroll generatedPayroll = new generatedPayroll(userID.Value.ToString(), year.Value.ToString(), month.Value.ToString());
            generatedPayroll.Show();
        }
    }
}
