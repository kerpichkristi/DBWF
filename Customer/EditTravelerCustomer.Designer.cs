
namespace DBWF
{
    partial class EditTravalerCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTravalerCustomer));
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.upPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.map = new System.Windows.Forms.Label();
            this.upPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(180, 233);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 21);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Location = new System.Drawing.Point(283, 230);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(266, 50);
            this.txtAddress.TabIndex = 14;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContact.Location = new System.Drawing.Point(184, 187);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(64, 21);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Contact";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(164, 143);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 21);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(283, 140);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(266, 28);
            this.txtLastName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(160, 100);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 21);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(283, 97);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(266, 28);
            this.txtFirstName.TabIndex = 8;
            // 
            // edit
            // 
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(81, 3);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 41);
            this.edit.TabIndex = 16;
            this.edit.Text = "Save";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContact.Location = new System.Drawing.Point(283, 184);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(266, 28);
            this.txtContact.TabIndex = 12;
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.upPanel.Controls.Add(this.button2);
            this.upPanel.Controls.Add(this.btnClose);
            this.upPanel.Controls.Add(this.edit);
            this.upPanel.Location = new System.Drawing.Point(0, -5);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(785, 44);
            this.upPanel.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(162, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "Clear";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(748, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 38);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(184, 342);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 21);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCity.Location = new System.Drawing.Point(283, 339);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(266, 28);
            this.txtCity.TabIndex = 21;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge.Location = new System.Drawing.Point(184, 299);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 21);
            this.lblAge.TabIndex = 24;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAge.Location = new System.Drawing.Point(283, 296);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(266, 28);
            this.txtAge.TabIndex = 23;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.MediumPurple;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 39);
            this.back.TabIndex = 25;
            this.back.Text = "Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(184, 385);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 21);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(283, 382);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 28);
            this.txtEmail.TabIndex = 26;
            // 
            // map
            // 
            this.map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.map.Image = ((System.Drawing.Image)(resources.GetObject("map.Image")));
            this.map.Location = new System.Drawing.Point(159, 72);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(460, 380);
            this.map.TabIndex = 43;
            // 
            // EditTravalerCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTravalerCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.upPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label map;
    }
}