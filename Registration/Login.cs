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

namespace DBWF
{
    public partial class Login : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DBWF; Integrated Security=True;";
        public Login()
        {
            InitializeComponent();
        }
        private void ViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                ViewPassword.SendToBack();
                txtPassword.PasswordChar = '\0';
            }
        }
        private void HidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                HidePassword.SendToBack();
                txtPassword.PasswordChar = '*';
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {   
            SqlConnection sqlCon = new SqlConnection(connectionString);
            string query = "Select role from tbUser where username = '" + txtUserName.Text.Trim() + 
                           "' and password = '" + HashPassword.GetHashPassword(txtPassword.Text.Trim()) +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
           
            try
            {
                string value = dtbl.Rows[0]["Role"].ToString().Trim();
                if (value == "Admin")
                {
                    frmMainAdmin objFrmMainAdmin = new frmMainAdmin();
                    this.Hide();
                    objFrmMainAdmin.Show();
                }
                else if (value == "Customer")
                {
                    frmMain objFrmMain = new frmMain();
                    this.Hide();
                    objFrmMain.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check your username and password");
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration objRegistration = new Registration();
            this.Hide();
            objRegistration.Show();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
