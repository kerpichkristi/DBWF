
namespace DBWF
{
    partial class EditRoutsAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoutsAdmin));
            this.Amount = new System.Windows.Forms.Label();
            this.lblTotalRouts = new System.Windows.Forms.Label();
            this.Dot = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dataGridViewRouts = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.upPanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblAmountOfKm = new System.Windows.Forms.Label();
            this.txtAmountOfKm = new System.Windows.Forms.TextBox();
            this.lblToCity = new System.Windows.Forms.Label();
            this.txtToCity = new System.Windows.Forms.TextBox();
            this.lblFromCity = new System.Windows.Forms.Label();
            this.txtFromCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRouts)).BeginInit();
            this.upPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(743, 432);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(13, 13);
            this.Amount.TabIndex = 59;
            this.Amount.Text = "0";
            // 
            // lblTotalRouts
            // 
            this.lblTotalRouts.AutoSize = true;
            this.lblTotalRouts.Location = new System.Drawing.Point(671, 432);
            this.lblTotalRouts.Name = "lblTotalRouts";
            this.lblTotalRouts.Size = new System.Drawing.Size(65, 13);
            this.lblTotalRouts.TabIndex = 58;
            this.lblTotalRouts.Text = "Total Routs:";
            // 
            // Dot
            // 
            this.Dot.AutoSize = true;
            this.Dot.BackColor = System.Drawing.Color.Transparent;
            this.Dot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dot.ForeColor = System.Drawing.Color.Red;
            this.Dot.Location = new System.Drawing.Point(294, 125);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(14, 16);
            this.Dot.TabIndex = 57;
            this.Dot.Text = "*";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(693, 61);
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
            this.txtSearch.Location = new System.Drawing.Point(324, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(352, 28);
            this.txtSearch.TabIndex = 53;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(8, 125);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 21);
            this.lblUserName.TabIndex = 52;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(102, 122);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(207, 28);
            this.txtUserName.TabIndex = 51;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // dataGridViewRouts
            // 
            this.dataGridViewRouts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRouts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.FromCity,
            this.ToCity,
            this.AmountOfKm,
            this.Date,
            this.Equipment});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRouts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRouts.GridColor = System.Drawing.Color.White;
            this.dataGridViewRouts.Location = new System.Drawing.Point(324, 104);
            this.dataGridViewRouts.Name = "dataGridViewRouts";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRouts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewRouts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRouts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewRouts.Size = new System.Drawing.Size(447, 314);
            this.dataGridViewRouts.TabIndex = 50;
            this.dataGridViewRouts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRouts_CellDoubleClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            // 
            // FromCity
            // 
            this.FromCity.HeaderText = "From City";
            this.FromCity.Name = "FromCity";
            // 
            // ToCity
            // 
            this.ToCity.HeaderText = "To City";
            this.ToCity.Name = "ToCity";
            // 
            // AmountOfKm
            // 
            this.AmountOfKm.HeaderText = "KM";
            this.AmountOfKm.Name = "AmountOfKm";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Equipment
            // 
            this.Equipment.HeaderText = "Equipment";
            this.Equipment.Name = "Equipment";
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
            this.btnBack.Location = new System.Drawing.Point(-1, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 44);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEquipment.Location = new System.Drawing.Point(12, 343);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(87, 21);
            this.lblEquipment.TabIndex = 48;
            this.lblEquipment.Text = "Equipment";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEquipment.Location = new System.Drawing.Point(102, 340);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(207, 28);
            this.txtEquipment.TabIndex = 47;
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.upPanel.Controls.Add(this.btnClear);
            this.upPanel.Controls.Add(this.btnDelete);
            this.upPanel.Controls.Add(this.btnClose);
            this.upPanel.Controls.Add(this.btnEdit);
            this.upPanel.Location = new System.Drawing.Point(-1, -1);
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
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(28, 302);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 21);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDate.Location = new System.Drawing.Point(102, 299);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(207, 24);
            this.txtDate.TabIndex = 42;
            // 
            // lblAmountOfKm
            // 
            this.lblAmountOfKm.AutoSize = true;
            this.lblAmountOfKm.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountOfKm.Location = new System.Drawing.Point(32, 256);
            this.lblAmountOfKm.Name = "lblAmountOfKm";
            this.lblAmountOfKm.Size = new System.Drawing.Size(37, 21);
            this.lblAmountOfKm.TabIndex = 41;
            this.lblAmountOfKm.Text = "KM";
            // 
            // txtAmountOfKm
            // 
            this.txtAmountOfKm.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmountOfKm.Location = new System.Drawing.Point(102, 253);
            this.txtAmountOfKm.Name = "txtAmountOfKm";
            this.txtAmountOfKm.Size = new System.Drawing.Size(207, 28);
            this.txtAmountOfKm.TabIndex = 40;
            // 
            // lblToCity
            // 
            this.lblToCity.AutoSize = true;
            this.lblToCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToCity.Location = new System.Drawing.Point(12, 212);
            this.lblToCity.Name = "lblToCity";
            this.lblToCity.Size = new System.Drawing.Size(62, 21);
            this.lblToCity.TabIndex = 39;
            this.lblToCity.Text = "To City";
            // 
            // txtToCity
            // 
            this.txtToCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToCity.Location = new System.Drawing.Point(102, 209);
            this.txtToCity.Name = "txtToCity";
            this.txtToCity.Size = new System.Drawing.Size(207, 28);
            this.txtToCity.TabIndex = 38;
            // 
            // lblFromCity
            // 
            this.lblFromCity.AutoSize = true;
            this.lblFromCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFromCity.Location = new System.Drawing.Point(8, 169);
            this.lblFromCity.Name = "lblFromCity";
            this.lblFromCity.Size = new System.Drawing.Size(81, 21);
            this.lblFromCity.TabIndex = 37;
            this.lblFromCity.Text = "From City";
            // 
            // txtFromCity
            // 
            this.txtFromCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromCity.Location = new System.Drawing.Point(102, 166);
            this.txtFromCity.Name = "txtFromCity";
            this.txtFromCity.Size = new System.Drawing.Size(207, 28);
            this.txtFromCity.TabIndex = 36;
            // 
            // EditRoutsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.lblTotalRouts);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.dataGridViewRouts);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblAmountOfKm);
            this.Controls.Add(this.txtAmountOfKm);
            this.Controls.Add(this.lblToCity);
            this.Controls.Add(this.txtToCity);
            this.Controls.Add(this.lblFromCity);
            this.Controls.Add(this.txtFromCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRoutsAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRoutsAdmin";
            this.Load += new System.EventHandler(this.EditRoutsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRouts)).EndInit();
            this.upPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label lblTotalRouts;

        private System.Windows.Forms.Label Dot;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridView dataGridViewRouts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button btnClear;


        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblAmountOfKm;
        private System.Windows.Forms.TextBox txtAmountOfKm;
        private System.Windows.Forms.Label lblToCity;
        private System.Windows.Forms.TextBox txtToCity;
        private System.Windows.Forms.Label lblFromCity;
        private System.Windows.Forms.TextBox txtFromCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
    }
}