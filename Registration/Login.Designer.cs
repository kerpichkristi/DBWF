
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gray;
            this.lblUserName.Location = new System.Drawing.Point(107, 122);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 21);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(107, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(111, 146);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 25);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(111, 225);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(261, 25);
            this.txtPassword.TabIndex = 3;
            // 
            // ViewPassword
            // 
            this.ViewPassword.BackColor = System.Drawing.Color.White;
            this.ViewPassword.FlatAppearance.BorderSize = 0;
            this.ViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPassword.Image = ((System.Drawing.Image)(resources.GetObject("ViewPassword.Image")));
            this.ViewPassword.Location = new System.Drawing.Point(375, 227);
            this.ViewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Size = new System.Drawing.Size(29, 21);
            this.ViewPassword.TabIndex = 20;
            this.ViewPassword.UseVisualStyleBackColor = false;
            this.ViewPassword.Click += new System.EventHandler(this.ViewPassword_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.BackColor = System.Drawing.Color.White;
            this.HidePassword.FlatAppearance.BorderSize = 0;
            this.HidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePassword.Image = ((System.Drawing.Image)(resources.GetObject("HidePassword.Image")));
            this.HidePassword.Location = new System.Drawing.Point(375, 227);
            this.HidePassword.Margin = new System.Windows.Forms.Padding(0);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(29, 21);
            this.HidePassword.TabIndex = 21;
            this.HidePassword.UseVisualStyleBackColor = false;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // signIn
            // 
            this.signIn.BackColor = System.Drawing.Color.MediumPurple;
            this.signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signIn.ForeColor = System.Drawing.Color.White;
            this.signIn.Location = new System.Drawing.Point(111, 281);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(261, 33);
            this.signIn.TabIndex = 22;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = false;
            this.signIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // linkRegistration
            // 
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkRegistration.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkRegistration.LinkColor = System.Drawing.Color.MediumPurple;
            this.linkRegistration.Location = new System.Drawing.Point(164, 367);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(159, 22);
            this.linkRegistration.TabIndex = 23;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Create new Account";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(195, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(158, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "If You Havent Account";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkRegistration);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.ViewPassword);
            this.Controls.Add(this.HidePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}