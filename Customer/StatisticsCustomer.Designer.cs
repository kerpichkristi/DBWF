
namespace DBWF.Customer
{
    partial class StatisticsCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsCustomer));
            this.back = new System.Windows.Forms.Button();
            this.upPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.back.TabIndex = 43;
            this.back.Text = "Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.upPanel.Controls.Add(this.btnClose);
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(785, 44);
            this.upPanel.TabIndex = 42;
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
            // StatisticsCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.back);
            this.Controls.Add(this.upPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsCustomer";
            this.upPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button btnClose;
    }
}