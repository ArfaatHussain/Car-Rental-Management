﻿namespace Car_Rental_Management
{
    partial class CustomerPendingBookings
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
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            removeBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(312, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(427, 54);
            label1.TabIndex = 0;
            label1.Text = "Your Pending Bookings";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(-1, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(1055, 359);
            dataGridView1.TabIndex = 1;
            // 
            // removeBtn
            // 
            removeBtn.Location = new System.Drawing.Point(276, 137);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new System.Drawing.Size(510, 48);
            removeBtn.TabIndex = 2;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(899, 47);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 40);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CustomerPendingBookings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1054, 599);
            Controls.Add(button1);
            Controls.Add(removeBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CustomerPendingBookings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CustomerBookings";
            Load += CustomerPendingBookings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button button1;
    }
}