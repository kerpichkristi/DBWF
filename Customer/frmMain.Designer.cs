
namespace DBWF
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.logOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnAddRout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtInformationUser = new System.Windows.Forms.Label();
            this.txtInformationUser2 = new System.Windows.Forms.Label();
            this.map = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.MediumPurple;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.Location = new System.Drawing.Point(0, 426);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(100, 36);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.btnAddRout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnStatistics);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 464);
            this.panel1.TabIndex = 1;
            // 
            // btnStatistics
            // 
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(0, 187);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(100, 41);
            this.btnStatistics.TabIndex = 21;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnAddRout
            // 
            this.btnAddRout.FlatAppearance.BorderSize = 0;
            this.btnAddRout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnAddRout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRout.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRout.ForeColor = System.Drawing.Color.White;
            this.btnAddRout.Location = new System.Drawing.Point(0, 126);
            this.btnAddRout.Name = "btnAddRout";
            this.btnAddRout.Size = new System.Drawing.Size(100, 55);
            this.btnAddRout.TabIndex = 20;
            this.btnAddRout.Text = "Add New Rout";
            this.btnAddRout.UseVisualStyleBackColor = true;
            this.btnAddRout.Click += new System.EventHandler(this.btnAddRout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit Traveler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(759, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 18;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblWelcome.Location = new System.Drawing.Point(241, 90);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(138, 37);
            this.lblWelcome.TabIndex = 19;
            this.lblWelcome.Text = "Welcome ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblUserName.Location = new System.Drawing.Point(374, 90);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 37);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "*****";
            // 
            // txtInformationUser
            // 
            this.txtInformationUser.AutoSize = true;
            this.txtInformationUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInformationUser.Location = new System.Drawing.Point(244, 155);
            this.txtInformationUser.Name = "txtInformationUser";
            this.txtInformationUser.Size = new System.Drawing.Size(110, 192);
            this.txtInformationUser.TabIndex = 21;
            this.txtInformationUser.Text = "User Name:\r\nFirst Name:\r\nLast Name:\r\nAge:\r\nContact:\r\nEmail:\r\nCity:\r\nAddress:";
            // 
            // txtInformationUser2
            // 
            this.txtInformationUser2.AutoSize = true;
            this.txtInformationUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInformationUser2.Location = new System.Drawing.Point(360, 155);
            this.txtInformationUser2.Name = "txtInformationUser2";
            this.txtInformationUser2.Size = new System.Drawing.Size(31, 24);
            this.txtInformationUser2.TabIndex = 22;
            this.txtInformationUser2.Text = "***";
            // 
            // map
            // 
            this.map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.map.Image = ((System.Drawing.Image)(resources.GetObject("map.Image")));
            this.map.Location = new System.Drawing.Point(310, 55);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(476, 407);
            this.map.TabIndex = 43;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtInformationUser2);
            this.Controls.Add(this.txtInformationUser);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddRout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label txtInformationUser;
        private System.Windows.Forms.Label txtInformationUser2;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label map;
    }
}