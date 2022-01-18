
namespace DBWF
{
    partial class AddRout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRout));
            this.back = new System.Windows.Forms.Button();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.upPanel = new System.Windows.Forms.Panel();
            this.edit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmountOfKm = new System.Windows.Forms.Label();
            this.txtAmountOfKm = new System.Windows.Forms.TextBox();
            this.lblToCity = new System.Windows.Forms.Label();
            this.txtToCity = new System.Windows.Forms.TextBox();
            this.lblFromCity = new System.Windows.Forms.Label();
            this.txtFromCity = new System.Windows.Forms.TextBox();
            this.map = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.upPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.back.Location = new System.Drawing.Point(0, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 39);
            this.back.TabIndex = 41;
            this.back.Text = "Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEquipment.Location = new System.Drawing.Point(192, 317);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(87, 21);
            this.lblEquipment.TabIndex = 40;
            this.lblEquipment.Text = "Equipment";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEquipment.Location = new System.Drawing.Point(321, 317);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(266, 28);
            this.txtEquipment.TabIndex = 39;
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
            this.button2.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.upPanel.Controls.Add(this.button2);
            this.upPanel.Controls.Add(this.btnClose);
            this.upPanel.Controls.Add(this.edit);
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(785, 44);
            this.upPanel.TabIndex = 36;
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
            this.edit.Text = "Add";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(215, 276);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 21);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Date";
            // 
            // lblAmountOfKm
            // 
            this.lblAmountOfKm.AutoSize = true;
            this.lblAmountOfKm.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountOfKm.Location = new System.Drawing.Point(222, 242);
            this.lblAmountOfKm.Name = "lblAmountOfKm";
            this.lblAmountOfKm.Size = new System.Drawing.Size(35, 21);
            this.lblAmountOfKm.TabIndex = 33;
            this.lblAmountOfKm.Text = "Km";
            // 
            // txtAmountOfKm
            // 
            this.txtAmountOfKm.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmountOfKm.Location = new System.Drawing.Point(321, 239);
            this.txtAmountOfKm.Name = "txtAmountOfKm";
            this.txtAmountOfKm.Size = new System.Drawing.Size(266, 28);
            this.txtAmountOfKm.TabIndex = 32;
            // 
            // lblToCity
            // 
            this.lblToCity.AutoSize = true;
            this.lblToCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToCity.Location = new System.Drawing.Point(202, 198);
            this.lblToCity.Name = "lblToCity";
            this.lblToCity.Size = new System.Drawing.Size(62, 21);
            this.lblToCity.TabIndex = 31;
            this.lblToCity.Text = "To City";
            // 
            // txtToCity
            // 
            this.txtToCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToCity.Location = new System.Drawing.Point(321, 195);
            this.txtToCity.Name = "txtToCity";
            this.txtToCity.Size = new System.Drawing.Size(266, 28);
            this.txtToCity.TabIndex = 30;
            // 
            // lblFromCity
            // 
            this.lblFromCity.AutoSize = true;
            this.lblFromCity.BackColor = System.Drawing.Color.Transparent;
            this.lblFromCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFromCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFromCity.Location = new System.Drawing.Point(198, 155);
            this.lblFromCity.Name = "lblFromCity";
            this.lblFromCity.Size = new System.Drawing.Size(81, 21);
            this.lblFromCity.TabIndex = 29;
            this.lblFromCity.Text = "From City";
            // 
            // txtFromCity
            // 
            this.txtFromCity.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromCity.Location = new System.Drawing.Point(321, 152);
            this.txtFromCity.Name = "txtFromCity";
            this.txtFromCity.Size = new System.Drawing.Size(266, 28);
            this.txtFromCity.TabIndex = 28;
            // 
            // map
            // 
            this.map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.map.Image = ((System.Drawing.Image)(resources.GetObject("map.Image")));
            this.map.Location = new System.Drawing.Point(172, 72);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(460, 380);
            this.map.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(572, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(572, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(572, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(546, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "*";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 24);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // AddRout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAmountOfKm);
            this.Controls.Add(this.txtAmountOfKm);
            this.Controls.Add(this.lblToCity);
            this.Controls.Add(this.txtToCity);
            this.Controls.Add(this.lblFromCity);
            this.Controls.Add(this.txtFromCity);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRout";
            this.upPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmountOfKm;
        private System.Windows.Forms.TextBox txtAmountOfKm;
        private System.Windows.Forms.Label lblToCity;
        private System.Windows.Forms.TextBox txtToCity;
        private System.Windows.Forms.Label lblFromCity;
        private System.Windows.Forms.TextBox txtFromCity;
        private System.Windows.Forms.Label map;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}