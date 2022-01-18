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
    public partial class EditUsersAdmin : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True";

        public EditUsersAdmin()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainAdmin objfrmMainAdmin = new frmMainAdmin();
            this.Hide();
            objfrmMainAdmin.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtRole.Text == "Customer")
            {
                try
                {

                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("Update tbUser set role = '" + txtRole.Text.Trim() + "' where UserName = '" + txtUserName.Text.Trim() + "'", sqlCon);

                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Edited successfully");
                            Clear();
                            sqlCon.Close();
                        }
                        FillDataGridVies();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else if (txtRole.Text == "Admin")
            {
                try
                {

                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("Update tbUser set role = '" + txtRole.Text.Trim() + "' where UserName = '" + txtUserName.Text.Trim() + "'", sqlCon);

                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Edited successfully");
                            Clear();
                            sqlCon.Close();
                        }
                        FillDataGridVies();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
                MessageBox.Show("Please set role 'Admin' or 'Customer'");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")

            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("Delete from tbUser where username = '" + txtUserName.Text.Trim() + "'", sqlCon);
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
        private void dataGridViewTraveler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTraveler.CurrentRow.Index != -1)
            {
                txtUserName.Text = dataGridViewTraveler.CurrentRow.Cells[0].Value.ToString();
                txtRole.Text = dataGridViewTraveler.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
        void Clear()
        {
            txtUserName.Text = txtRole.Text = txtSearch.Text = "";
        }
        private void FillDataGridVies()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tbUser WHERE UserName LIKE '" + txtSearch.Text.Trim() + "' + '%' ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridViewTraveler.Rows.Clear();
                foreach (DataRow item in dtbl.Rows)
                {
                    int n = dataGridViewTraveler.Rows.Add();
                    dataGridViewTraveler.Rows[n].Cells[0].Value = item["UserName"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[1].Value = item["Password"].ToString();
                    dataGridViewTraveler.Rows[n].Cells[2].Value = item["Role"].ToString();
                }
                Amount.Text = dtbl.Rows.Count.ToString();
                sqlCon.Close();
            }
        }

        
       
    }
}
