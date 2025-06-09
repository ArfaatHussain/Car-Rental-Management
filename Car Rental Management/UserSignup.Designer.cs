namespace Car_Rental_Management
{
    partial class UserSignup
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
            nameTextBox = new System.Windows.Forms.TextBox();
            emailTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            passwordTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            addressTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            phoneTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            signupBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(334, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(297, 54);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(215, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(334, 152);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(388, 31);
            nameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new System.Drawing.Point(334, 213);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(388, 31);
            emailTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(215, 216);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 25);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(334, 277);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new System.Drawing.Size(388, 31);
            passwordTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(215, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new System.Drawing.Point(334, 344);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new System.Drawing.Size(388, 31);
            addressTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(215, 347);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 25);
            label5.TabIndex = 7;
            label5.Text = "Address";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new System.Drawing.Point(334, 410);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new System.Drawing.Size(388, 31);
            phoneTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(215, 413);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 25);
            label6.TabIndex = 9;
            label6.Text = "Phone";
            // 
            // signupBtn
            // 
            signupBtn.Location = new System.Drawing.Point(610, 482);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new System.Drawing.Size(112, 44);
            signupBtn.TabIndex = 11;
            signupBtn.Text = "Signup";
            signupBtn.UseVisualStyleBackColor = true;
            signupBtn.Click += signupBtn_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(334, 482);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 44);
            button1.TabIndex = 12;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserSignup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1014, 583);
            Controls.Add(button1);
            Controls.Add(signupBtn);
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
            Controls.Add(label1);
            Name = "UserSignup";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "UserSignup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Button button1;
    }
}