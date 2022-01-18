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
    public partial class AddRout : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True";

        public AddRout()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            frmMain objfrmMain = new frmMain();
            this.Hide();
            objfrmMain.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (txtFromCity.Text != "" || txtToCity.Text != "" || 
                txtAmountOfKm.Text != "" || dateTimePicker1.Text != "")
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("AddRout", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.AddWithValue("@UserName", SaveUser.ActiveUser.Trim());
                        sqlCmd.Parameters.AddWithValue("@FromCity", txtFromCity.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@ToCity", txtToCity.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@AmountOfKm", txtAmountOfKm.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Equipment", txtEquipment.Text.Trim());

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Add successfully");
                        Clear();
                        sqlCon.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
            }
            else
                MessageBox.Show("Mandatory fields are empty");
           
        }
        void Clear()
        {
            txtFromCity.Text = txtToCity.Text = txtAmountOfKm.Text = dateTimePicker1.Text = txtEquipment.Text  = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
