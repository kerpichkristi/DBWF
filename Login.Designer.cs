
namespace DBWF
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ViewPassword = new System.Windows.Forms.Button();
            this.HidePassword = new System.Windows.Forms.Button();
            this.signIn = new System.Windows.Forms.Button();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(51, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 21);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(60, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(145, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(179, 25);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(145, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 25);
            this.txtPassword.TabIndex = 3;
            // 
            // ViewPassword
            // 
            this.ViewPassword.BackColor = System.Drawing.Color.FloralWhite;
            this.ViewPassword.FlatAppearance.BorderSize = 0;
            this.ViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPassword.Image = ((System.Drawing.Image)(resources.GetObject("ViewPassword.Image")));
            this.ViewPassword.Location = new System.Drawing.Point(327, 70);
            this.ViewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Size = new System.Drawing.Size(29, 21);
            this.ViewPassword.TabIndex = 20;
            this.ViewPassword.UseVisualStyleBackColor = false;
            this.ViewPassword.Click += new System.EventHandler(this.ViewPassword_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.BackColor = System.Drawing.Color.FloralWhite;
            this.HidePassword.FlatAppearance.BorderSize = 0;
            this.HidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePassword.Image = ((System.Drawing.Image)(resources.GetObject("HidePassword.Image")));
            this.HidePassword.Location = new System.Drawing.Point(327, 70);
            this.HidePassword.Margin = new System.Windows.Forms.Padding(0);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(29, 21);
            this.HidePassword.TabIndex = 21;
            this.HidePassword.UseVisualStyleBackColor = false;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(198, 112);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 23);
            this.signIn.TabIndex = 22;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // linkRegistration
            // 
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Location = new System.Drawing.Point(306, 140);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(104, 13);
            this.linkRegistration.TabIndex = 23;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Create new Account";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(412, 162);
            this.Controls.Add(this.linkRegistration);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.ViewPassword);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button ViewPassword;
        private System.Windows.Forms.Button HidePassword;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.LinkLabel linkRegistration;
    }
}