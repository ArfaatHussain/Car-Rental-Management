namespace Car_Rental_Management
{
    partial class UpdateCustomerProfile
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
            customerNameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            emailTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            passwordTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            addressTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            phoneTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(202, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(339, 49);
            label1.TabIndex = 0;
            label1.Text = "Change Your Profile";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            customerNameLabel.Location = new System.Drawing.Point(533, 37);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(134, 49);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Text = "Arfaat!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(202, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(296, 127);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(433, 31);
            nameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new System.Drawing.Point(296, 195);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(433, 31);
            emailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(202, 198);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(296, 263);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new System.Drawing.Size(433, 31);
            passwordTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(202, 266);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 25);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new System.Drawing.Point(296, 333);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new System.Drawing.Size(433, 31);
            addressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(202, 336);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 25);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new System.Drawing.Point(296, 400);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new System.Drawing.Size(433, 31);
            phoneTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(202, 403);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 25);
            label6.TabIndex = 10;
            label6.Text = "Phone";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(590, 468);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(139, 47);
            button1.TabIndex = 14;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(786, 39);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(122, 47);
            button2.TabIndex = 15;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UpdateCustomerProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(935, 553);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(phoneTextBox);
            Controls.Add(label6);
            Controls.Add(addressTextBox);
            Controls.Add(label5);
            Controls.Add(passwordTextBox);
            Controls.Add(label4);
            Controls.Add(emailTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(customerNameLabel);
            Controls.Add(label1);
            Name = "UpdateCustomerProfile";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "UpdateCustomerProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}