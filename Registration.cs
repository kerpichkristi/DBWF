using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DBWF
{
    public partial class Registration : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True";
        public Registration()
        {
            InitializeComponent();
        }
        private void View_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                ViewPassword.SendToBack();
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
        }
        private void Hide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                HidePassword.SendToBack();
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill manatory fields");
            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Paasword do not match");
            else {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", HashPassword.GetHashPassword(txtPassword.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Role", "Customer");
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    Clear();
                }
            }
        }
        void Clear() 
        {
         txtUserName.Text = txtPassword.Text = txtConfirmPassword.Text = "";
        }

       
        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login objLogin = new Login();
            this.Hide();
            objLogin.Show();
        }

       
    }
}
