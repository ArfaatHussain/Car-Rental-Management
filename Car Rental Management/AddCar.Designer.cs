namespace Car_Rental_Management
{
    partial class AddCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricePerDayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(261, 131);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(409, 26);
            this.makeTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(261, 200);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(409, 26);
            this.modelTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // pricePerDayTextBox
            // 
            this.pricePerDayTextBox.Location = new System.Drawing.Point(265, 330);
            this.pricePerDayTextBox.Name = "pricePerDayTextBox";
            this.pricePerDayTextBox.Size = new System.Drawing.Size(409, 26);
            this.pricePerDayTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price Per Day";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(265, 261);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(409, 26);
            this.yearTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Available";
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(265, 395);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(62, 24);
            this.r1.TabIndex = 10;
            this.r1.TabStop = true;
            this.r1.Text = "Yes";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(474, 395);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(54, 24);
            this.r2.TabIndex = 11;
            this.r2.TabStop = true;
            this.r2.Text = "No";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(41, 30);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 49);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 620);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pricePerDayTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricePerDayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backBtn;
    }
}