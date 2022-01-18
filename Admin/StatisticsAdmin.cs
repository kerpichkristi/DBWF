using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWF.Admin
{
    public partial class StatisticsAdmin : Form
    {
        public StatisticsAdmin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            frmMainAdmin objfrmMainAdmin = new frmMainAdmin();
            this.Hide();
            objfrmMainAdmin.Show();
        }
    }
}
