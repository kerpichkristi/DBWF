
namespace DBWF
{
    partial class frmMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAdmin));
            this.logOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnEditRouts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.btnStatistics);
            this.panel1.Controls.Add(this.btnEditUsers);
            this.panel1.Controls.Add(this.btnEditRouts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 464);
            this.panel1.TabIndex = 2;
            // 
            // btnStatistics
            // 
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(0, 278);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(100, 52);
            this.btnStatistics.TabIndex = 7;
            this.btnStatistics.Text = "Statistics And Reports";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.FlatAppearance.BorderSize = 0;
            this.btnEditUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnEditUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUsers.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditUsers.ForeColor = System.Drawing.Color.White;
            this.btnEditUsers.Location = new System.Drawing.Point(0, 220);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(100, 52);
            this.btnEditUsers.TabIndex = 6;
            this.btnEditUsers.Text = "Edit Users";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnEditRouts
            // 
            this.btnEditRouts.FlatAppearance.BorderSize = 0;
            this.btnEditRouts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnEditRouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRouts.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditRouts.ForeColor = System.Drawing.Color.White;
            this.btnEditRouts.Location = new System.Drawing.Point(0, 162);
            this.btnEditRouts.Name = "btnEditRouts";
            this.btnEditRouts.Size = new System.Drawing.Size(100, 52);
            this.btnEditRouts.TabIndex = 5;
            this.btnEditRouts.Text = "Edit Routs";
            this.btnEditRouts.UseVisualStyleBackColor = true;
            this.btnEditRouts.Click += new System.EventHandler(this.btnEditRouts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard\r\n  (Admin)";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit Traveler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(757, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Close_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblWelcome.Location = new System.Drawing.Point(261, 74);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(225, 37);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.Text = "Welcome Admin";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInformation.Location = new System.Drawing.Point(263, 160);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(326, 75);
            this.lblInformation.TabIndex = 22;
            this.lblInformation.Text = "In This Dashboard You Can Edit \r\n\r\nInformation And See Statistics";
            // 
            // map
            // 
            this.map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.map.Image = ((System.Drawing.Image)(resources.GetObject("map.Image")));
            this.map.Location = new System.Drawing.Point(341, 169);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(476, 407);
            this.map.TabIndex = 44;
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard(Admin)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnEditRouts;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label map;
    }
}