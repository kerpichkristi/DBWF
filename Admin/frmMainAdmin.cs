using DBWF.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWF
{
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Hide();
            objLogin.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditTravalerAdmin objEditTravalerAdmin = new EditTravalerAdmin();
            this.Hide();
            objEditTravalerAdmin.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditRouts_Click(object sender, EventArgs e)
        {
            EditRoutsAdmin objEditRoutsAdmin = new EditRoutsAdmin();
            this.Hide();
            objEditRoutsAdmin.Show();
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            EditUsersAdmin objEditUsersAdmin = new EditUsersAdmin();
            this.Hide();
            objEditUsersAdmin.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsAdmin objStatisticsAdmin = new StatisticsAdmin();
            this.Hide();
            objStatisticsAdmin.Show();
        }
    }
}
