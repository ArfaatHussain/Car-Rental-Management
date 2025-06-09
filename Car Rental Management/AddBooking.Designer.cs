namespace Car_Rental_Management
{
    partial class AddBooking
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
            label2 = new System.Windows.Forms.Label();
            makeTextBox = new System.Windows.Forms.TextBox();
            modelTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            yearTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            addBookingBtn = new System.Windows.Forms.Button();
            pricePerDayTextBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            amount = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(372, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(248, 54);
            label1.TabIndex = 0;
            label1.Text = "Add Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(214, 137);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Car Make";
            // 
            // makeTextBox
            // 
            makeTextBox.Enabled = false;
            makeTextBox.Location = new System.Drawing.Point(372, 134);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new System.Drawing.Size(440, 31);
            makeTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            modelTextBox.Enabled = false;
            modelTextBox.Location = new System.Drawing.Point(372, 199);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new System.Drawing.Size(440, 31);
            modelTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(214, 202);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 25);
            label3.TabIndex = 3;
            label3.Text = "Model";
            // 
            // yearTextBox
            // 
            yearTextBox.Enabled = false;
            yearTextBox.Location = new System.Drawing.Point(372, 261);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new System.Drawing.Size(440, 31);
            yearTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(214, 267);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 25);
            label4.TabIndex = 6;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(214, 381);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 25);
            label5.TabIndex = 8;
            label5.Text = "Start Date";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new System.Drawing.Point(372, 381);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new System.Drawing.Size(440, 31);
            startDateTimePicker.TabIndex = 9;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new System.Drawing.Point(372, 447);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new System.Drawing.Size(440, 31);
            endDateTimePicker.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(214, 447);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(84, 25);
            label6.TabIndex = 10;
            label6.Text = "End Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(214, 518);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(119, 25);
            label7.TabIndex = 12;
            label7.Text = "Total Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(372, 511);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(48, 35);
            label8.TabIndex = 13;
            label8.Text = "Rs.";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            amountLabel.Location = new System.Drawing.Point(442, 461);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(0, 35);
            amountLabel.TabIndex = 14;
            // 
            // addBookingBtn
            // 
            addBookingBtn.Location = new System.Drawing.Point(609, 571);
            addBookingBtn.Name = "addBookingBtn";
            addBookingBtn.Size = new System.Drawing.Size(203, 46);
            addBookingBtn.TabIndex = 15;
            addBookingBtn.Text = "Add";
            addBookingBtn.UseVisualStyleBackColor = true;
            addBookingBtn.Click += addBookingBtn_Click;
            // 
            // pricePerDayTextBox
            // 
            pricePerDayTextBox.Enabled = false;
            pricePerDayTextBox.Location = new System.Drawing.Point(372, 320);
            pricePerDayTextBox.Name = "pricePerDayTextBox";
            pricePerDayTextBox.Size = new System.Drawing.Size(440, 31);
            pricePerDayTextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(214, 320);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(112, 25);
            label9.TabIndex = 16;
            label9.Text = "Rent Per Day";
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            amount.Location = new System.Drawing.Point(442, 511);
            amount.Name = "amount";
            amount.Size = new System.Drawing.Size(0, 35);
            amount.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(699, 500);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(113, 46);
            button1.TabIndex = 19;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddBooking
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 677);
            Controls.Add(button1);
            Controls.Add(amount);
            Controls.Add(pricePerDayTextBox);
            Controls.Add(label9);
            Controls.Add(addBookingBtn);
            Controls.Add(amountLabel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(endDateTimePicker);
            Controls.Add(label6);
            Controls.Add(startDateTimePicker);
            Controls.Add(label5);
            Controls.Add(yearTextBox);
            Controls.Add(label4);
            Controls.Add(modelTextBox);
            Controls.Add(label3);
            Controls.Add(makeTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBooking";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AddBooking";
            Load += AddBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button addBookingBtn;
        private System.Windows.Forms.TextBox pricePerDayTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Button button1;
    }
}