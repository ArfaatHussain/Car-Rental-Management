namespace Car_Rental_Management
{
    partial class CustomerAcceptedBookings
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
            checkoutBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(315, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(451, 54);
            label1.TabIndex = 0;
            label1.Text = "Your Accepted Bookings";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(-2, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(1062, 338);
            dataGridView1.TabIndex = 1;
            // 
            // checkoutBtn
            // 
            checkoutBtn.Location = new System.Drawing.Point(241, 164);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new System.Drawing.Size(553, 49);
            checkoutBtn.TabIndex = 2;
            checkoutBtn.Text = "Checkout";
            checkoutBtn.UseVisualStyleBackColor = true;
            checkoutBtn.Click += checkoutBtn_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(926, 44);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 46);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CustomerAcceptedBookings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1059, 597);
            Controls.Add(button1);
            Controls.Add(checkoutBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CustomerAcceptedBookings";
            Text = "CustomerAcceptedBookings";
            Load += CustomerAcceptedBookings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Button button1;
    }
}