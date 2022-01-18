using DBWF.Customer;
using DBWF.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWF
{
    public partial class frmMain : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True";

        public frmMain()
        {
            InitializeComponent();
            lblUserName.Text = SaveUser.ActiveUser.ToString();
/*
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("select * from tbUser where username = '" + SaveUser.ActiveUser.ToString() +"'", sqlCon);

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't Get Information About User");
            }*/
           
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Hide();
            objLogin.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditTravalerCustomer objEditTravalerCustomer = new EditTravalerCustomer();
            this.Hide();
            objEditTravalerCustomer.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRout_Click(object sender, EventArgs e)
        {
            AddRout objAddRout = new AddRout();
            this.Hide();
            objAddRout.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsCustomer objStatisticsCustomer = new StatisticsCustomer();
            this.Hide();
            objStatisticsCustomer.Show();
        }


    }
}
