
namespace DBWF
{
    partial class Registration
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.mandatoryDot1 = new System.Windows.Forms.Label();
            this.mandatoryDot2 = new System.Windows.Forms.Label();
            this.mandatoryDot3 = new System.Windows.Forms.Label();
            this.ViewPassword = new System.Windows.Forms.Button();
            this.HidePassword = new System.Windows.Forms.Button();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gray;
            this.lblUserName.Location = new System.Drawing.Point(108, 122);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 21);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(108, 146);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 28);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(108, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 21);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(108, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(261, 28);
            this.txtPassword.TabIndex = 10;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblConfirmPassword.Location = new System.Drawing.Point(108, 280);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(141, 21);
            this.lblConfirmPassword.TabIndex = 13;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(108, 307);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(261, 28);
            this.txtConfirmPassword.TabIndex = 12;
            // 
            // submit
            // 
            this.submit.AutoEllipsis = true;
            this.submit.BackColor = System.Drawing.Color.MediumPurple;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(107, 372);
            this.submit.Name = "submit";
            this.submit.Padding = new System.Windows.Forms.Padding(1);
            this.submit.Size = new System.Drawing.Size(262, 35);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // mandatoryDot1
            // 
            this.mandatoryDot1.AutoSize = true;
            this.mandatoryDot1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mandatoryDot1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryDot1.ForeColor = System.Drawing.Color.Red;
            this.mandatoryDot1.Location = new System.Drawing.Point(351, 149);
            this.mandatoryDot1.Name = "mandatoryDot1";
            this.mandatoryDot1.Size = new System.Drawing.Size(17, 21);
            this.mandatoryDot1.TabIndex = 16;
            this.mandatoryDot1.Text = "*";
            this.mandatoryDot1.Click += new System.EventHandler(this.mandatoryDot1_Click);
            // 
            // mandatoryDot2
            // 
            this.mandatoryDot2.AutoSize = true;
            this.mandatoryDot2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mandatoryDot2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryDot2.ForeColor = System.Drawing.Color.Red;
            this.mandatoryDot2.Location = new System.Drawing.Point(351, 227);
            this.mandatoryDot2.Name = "mandatoryDot2";
            this.mandatoryDot2.Size = new System.Drawing.Size(17, 21);
            this.mandatoryDot2.TabIndex = 17;
            this.mandatoryDot2.Text = "*";
            // 
            // mandatoryDot3
            // 
            this.mandatoryDot3.AutoSize = true;
            this.mandatoryDot3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mandatoryDot3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryDot3.ForeColor = System.Drawing.Color.Red;
            this.mandatoryDot3.Location = new System.Drawing.Point(351, 310);
            this.mandatoryDot3.Name = "mandatoryDot3";
            this.mandatoryDot3.Size = new System.Drawing.Size(17, 21);
            this.mandatoryDot3.TabIndex = 18;
            this.mandatoryDot3.Text = "*";
            this.mandatoryDot3.Click += new System.EventHandler(this.mandatoryDot3_Click);
            // 
            // ViewPassword
            // 
            this.ViewPassword.BackColor = System.Drawing.Color.Transparent;
            this.ViewPassword.FlatAppearance.BorderSize = 0;
            this.ViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPassword.Image = ((System.Drawing.Image)(resources.GetObject("ViewPassword.Image")));
            this.ViewPassword.Location = new System.Drawing.Point(372, 228);
            this.ViewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Size = new System.Drawing.Size(29, 21);
            this.ViewPassword.TabIndex = 19;
            this.ViewPassword.UseVisualStyleBackColor = false;
            this.ViewPassword.Click += new System.EventHandler(this.View_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.BackColor = System.Drawing.Color.Transparent;
            this.HidePassword.FlatAppearance.BorderSize = 0;
            this.HidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePassword.Image = ((System.Drawing.Image)(resources.GetObject("HidePassword.Image")));
            this.HidePassword.Location = new System.Drawing.Point(372, 228);
            this.HidePassword.Margin = new System.Windows.Forms.Padding(0);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(29, 21);
            this.HidePassword.TabIndex = 20;
            this.HidePassword.UseVisualStyleBackColor = false;
            this.HidePassword.Click += new System.EventHandler(this.Hide_Click);
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkSignIn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSignIn.LinkColor = System.Drawing.Color.MediumPurple;
            this.linkSignIn.Location = new System.Drawing.Point(177, 454);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(123, 22);
            this.linkSignIn.TabIndex = 21;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Create Account";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(151, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(154, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dont Have an Account";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkSignIn);
            this.Controls.Add(this.mandatoryDot2);
            this.Controls.Add(this.mandatoryDot1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.ViewPassword);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.mandatoryDot3);
            this.Controls.Add(this.txtConfirmPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;


        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label mandatoryDot1;
        private System.Windows.Forms.Label mandatoryDot2;
        private System.Windows.Forms.Label mandatoryDot3;
        private System.Windows.Forms.Button ViewPassword;
        private System.Windows.Forms.Button HidePassword;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
    

}

