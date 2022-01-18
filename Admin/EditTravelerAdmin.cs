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
    public partial class EditTravalerAdmin : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True";
       

        public EditTravalerAdmin()
        {
            InitializeComponent();
            try
            {
                FillDataGridVies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "Edit")
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UpdateTraveler", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
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
                    FillDataGridVies();
                }
                else if (btnEdit.Text == "Add")
                {
                    if (txtUserName.Text != "")
                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("AddTraveler", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Age", txtAge.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Add successfully");
                            Clear();
                            sqlCon.Close();

                        }
                        FillDataGridVies();
                    } else if (txtUserName.Text == "") {
                        MessageBox.Show("Please write User Name","Error");
                    }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        void Clear()
        {
            txtSearch.Text = txtUserName.Text = txtFirstName.Text = txtLastName.Text = txtContact.Text = txtAddress.Text = txtAge.Text = txtCity.Text = txtEmail.Text = "";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            frmMainAdmin objfrmMainAdmin = new frmMainAdmin();
            this.Hide();
            objfrmMainAdmin.Show();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            try 
            {
                FillDataGridVies();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
               
        }
        private void dataGridViewTraveler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTraveler.CurrentRow.Index != -1)
            {
                txtUserName.Text = dataGridViewTraveler.CurrentRow.Cells[0].Value.ToString();
                txtFirstName.Text = dataGridViewTraveler.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = dataGridViewTraveler.CurrentRow.Cells[2].Value.ToString();
                txtContact.Text = dataGridViewTraveler.CurrentRow.Cells[3].Value.ToString();
                txtAddress.Text = dataGridViewTraveler.CurrentRow.Cells[4].Value.ToString();
                txtAge.Text = dataGridViewTraveler.CurrentRow.Cells[5].Value.ToString();
                txtCity.Text = dataGridViewTraveler.CurrentRow.Cells[6].Value.ToString();
                txtEmail.Text = dataGridViewTraveler.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {   if (txtUserName.Text != "")

            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("Delete from tbTraveler where username = '" + txtUserName.Text.Trim() + "'", sqlCon);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Delete successfully");
                        Clear();
                        sqlCon.Close();
                    }
                    FillDataGridVies();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
                MessageBox.Show("Please write valid User Name", "User Name is empty");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            ChangedEditButton();
        }
        private void ChangedEditButton()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    string query = "Select UserName from tbTraveler where username = '" + txtUserName.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);

                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                    {
                        btnEdit.Text = "Edit";
                    }
                    else
                        btnEdit.Text = "Add";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User Name is empty");
            }
        }
        private void FillDataGridVies()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SearchOrViewTravel", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@UserName", txtSearch.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridViewTraveler.Rows.Clear();
                foreach (DataRow item in dtbl.Rows)
                {
                    int n = dataGridViewTraveler.Rows.Add();
                    dataGridViewTraveler.Rows[n].Cells[0].Value = item["UserName"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[1].Value = item["FirstName"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[2].Value = item["LastName"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[3].Value = item["Contact"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[4].Value = item["Address"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[5].Value = item["Age"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[6].Value = item["City"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[7].Value = item["Email"].ToString();

                }
               
                Amount.Text = dtbl.Rows.Count.ToString();
                sqlCon.Close();
            }
        }
    }
}
