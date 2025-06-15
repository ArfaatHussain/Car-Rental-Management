namespace Car_Rental_Management
{
    partial class AdminLogin
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
            loginBtn = new System.Windows.Forms.Button();
            passwordTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            usernameTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new System.Drawing.Point(629, 392);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new System.Drawing.Size(153, 44);
            loginBtn.TabIndex = 12;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(292, 306);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new System.Drawing.Size(463, 31);
            passwordTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(146, 309);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 25);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new System.Drawing.Point(292, 221);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(463, 31);
            usernameTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(259, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(452, 54);
            label2.TabIndex = 8;
            label2.Text = "Login To Admin Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(146, 224);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 25);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(451, 392);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(153, 44);
            button1.TabIndex = 13;
            button1.Text = "Skip";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(275, 392);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(153, 44);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 561);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}