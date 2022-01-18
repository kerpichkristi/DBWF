
namespace DBWF
{
    partial class EditUsersAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUsersAdmin));
            this.Amount = new System.Windows.Forms.Label();
            this.lblTotalTravelers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dataGridViewTraveler = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.upPanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraveler)).BeginInit();
            this.upPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(739, 432);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(13, 13);
            this.Amount.TabIndex = 59;
            this.Amount.Text = "0";
            // 
            // lblTotalTravelers
            // 
            this.lblTotalTravelers.AutoSize = true;
            this.lblTotalTravelers.Location = new System.Drawing.Point(672, 432);
            this.lblTotalTravelers.Name = "lblTotalTravelers";
            this.lblTotalTravelers.Size = new System.Drawing.Size(64, 13);
            this.lblTotalTravelers.TabIndex = 58;
            this.lblTotalTravelers.Text = "Total Users:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(372, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "*";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(549, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 28);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(180, 160);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(352, 28);
            this.txtSearch.TabIndex = 53;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(86, 103);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 21);
            this.lblUserName.TabIndex = 52;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(180, 100);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(207, 28);
            this.txtUserName.TabIndex = 51;
            // 
            // dataGridViewTraveler
            // 
            this.dataGridViewTraveler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTraveler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Password,
            this.Role});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTraveler.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTraveler.GridColor = System.Drawing.Color.White;
            this.dataGridViewTraveler.Location = new System.Drawing.Point(22, 211);
            this.dataGridViewTraveler.Name = "dataGridViewTraveler";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTraveler.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewTraveler.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTraveler.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewTraveler.Size = new System.Drawing.Size(750, 207);
            this.dataGridViewTraveler.TabIndex = 50;
            this.dataGridViewTraveler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTraveler_CellDoubleClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 44);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(81, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 41);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Add";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.upPanel.Controls.Add(this.btnClear);
            this.upPanel.Controls.Add(this.button1);
            this.upPanel.Controls.Add(this.btnDelete);
            this.upPanel.Controls.Add(this.btnClose);
            this.upPanel.Controls.Add(this.btnEdit);
            this.upPanel.Location = new System.Drawing.Point(0, -1);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(785, 44);
            this.upPanel.TabIndex = 44;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(239, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 39);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(162, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 39);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(749, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 38);
            this.btnClose.TabIndex = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.Location = new System.Drawing.Point(407, 101);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 21);
            this.lblRole.TabIndex = 39;
            this.lblRole.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRole.Location = new System.Drawing.Point(477, 98);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(207, 28);
            this.txtRole.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(669, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "*";
            // 
            // EditUsersAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.lblTotalTravelers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.dataGridViewTraveler);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUsersAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUsersAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraveler)).EndInit();
            this.upPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label lblTotalTravelers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridView dataGridViewTraveler;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Label label3;
    }
}