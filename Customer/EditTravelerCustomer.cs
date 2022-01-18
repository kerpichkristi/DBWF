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
    public partial class EditTravalerCustomer : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True";

        public EditTravalerCustomer()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UpdateTraveler", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@UserName", SaveUser.ActiveUser.Trim());
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Age", txtAge.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", txtCity.Text.Trim()); 
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Edited successfully");
                    Clear();
                    sqlCon.Close();
                }
                frmMain objfrmMain = new frmMain();
                this.Hide();
                objfrmMain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
           
                   
        }
            
            void Clear()
            {
            txtFirstName.Text = txtLastName.Text = txtContact.Text = txtAddress.Text = txtAge.Text = txtCity.Text = "";
            }

        private void Back_Click(object sender, EventArgs e)
        {
            frmMain objfrmMain = new frmMain();
            this.Hide();
            objfrmMain.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
