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
    public partial class EditTravalerAdmin : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True";

        public EditTravalerAdmin()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
          
              
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("AddTraveler", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());

                sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Edited successfully");
                        Clear();
                    }
                }
            
            void Clear()
            {
            txtFirstName.Text = txtLastName.Text = txtContact.Text = txtAddress.Text = "";
            }

    }
}
