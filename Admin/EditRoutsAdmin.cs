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
using System.Data.SqlClient;
using System.Configuration;

namespace DBWF
{
    public partial class EditRoutsAdmin : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True";
        public EditRoutsAdmin()
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

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "Edit")
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UpdateRout", sqlCon);

                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@FromCity", txtFromCity.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@ToCity", txtToCity.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@AmountOfKm", txtAmountOfKm.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Date", txtDate.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Equipment", txtEquipment.Text.Trim());
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
                            SqlCommand sqlCmd = new SqlCommand("AddRout", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@FromCity", txtFromCity.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@ToCity", txtToCity.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@AmountOfKm", txtAmountOfKm.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Date", txtDate.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Equipment", txtEquipment.Text.Trim());

                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Add successfully");
                            Clear();
                            sqlCon.Close();

                        }
                        FillDataGridVies();
                    }
                    else if (txtUserName.Text == "")
                    {
                        MessageBox.Show("Please write User Name", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void EditRoutsAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            ChangedEditButton();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (txtUserName.Text != "")

                {
                    try
                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("Delete from tbRouts where username ='" + txtUserName.Text.Trim() + "'", sqlCon); 
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
        }
        private void dataGridViewRouts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRouts.CurrentRow.Index != -1)
            {
                txtUserName.Text = dataGridViewRouts.CurrentRow.Cells[0].Value.ToString();
                txtFromCity.Text = dataGridViewRouts.CurrentRow.Cells[1].Value.ToString();
                txtToCity.Text = dataGridViewRouts.CurrentRow.Cells[2].Value.ToString();
                txtAmountOfKm.Text = dataGridViewRouts.CurrentRow.Cells[3].Value.ToString();
                txtDate.Text = dataGridViewRouts.CurrentRow.Cells[4].Value.ToString();
                txtEquipment.Text = dataGridViewRouts.CurrentRow.Cells[5].Value.ToString();
            }
        }
        private void FillDataGridVies()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbRouts WHERE UserName LIKE '" + txtSearch.Text.Trim() + "' + '%' ", sqlCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridViewRouts.Rows.Clear();
                foreach (DataRow item in dtbl.Rows)
                {
                    int n = dataGridViewRouts.Rows.Add();
                    dataGridViewRouts.Rows[n].Cells[0].Value = item["UserName"].ToString();
                    dataGridViewRouts.Rows[n].Cells[1].Value = item["FromCity"].ToString();
                    dataGridViewRouts.Rows[n].Cells[2].Value = item["ToCity"].ToString();
                    dataGridViewRouts.Rows[n].Cells[3].Value = item["AmountOfKm"].ToString();
                    dataGridViewRouts.Rows[n].Cells[4].Value = item["Date"].ToString();
                    dataGridViewRouts.Rows[n].Cells[5].Value = item["Equipment"].ToString();

                }

                Amount.Text = dtbl.Rows.Count.ToString();
                sqlCon.Close();
            }
        }
        private void ChangedEditButton()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    string query = "Select UserName from tbRouts where username = '" + txtUserName.Text.Trim() + "'";
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
        void Clear()
        {
            txtSearch.Text = txtUserName.Text = txtFromCity.Text = txtToCity.Text = txtAmountOfKm.Text = txtDate.Text = txtEquipment.Text = "";
        }

       
    }
}
