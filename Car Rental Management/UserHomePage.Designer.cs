namespace Car_Rental_Management
{
    partial class UserHomePage
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
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            searchBtn = new System.Windows.Forms.Button();
            searchComboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            searchTextBox = new System.Windows.Forms.TextBox();
            clearBtn = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(411, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(215, 54);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(27, 46);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(0, 25);
            nameLabel.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(27, 94);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(0, 25);
            emailLabel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(909, 46);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 54);
            button1.TabIndex = 3;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(-3, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(1064, 303);
            dataGridView1.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.Location = new System.Drawing.Point(753, 136);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new System.Drawing.Size(112, 47);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchComboBox
            // 
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "Model", "Make", "Price", "Year" });
            searchComboBox.Location = new System.Drawing.Point(186, 144);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new System.Drawing.Size(131, 33);
            searchComboBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(66, 147);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 25);
            label2.TabIndex = 7;
            label2.Text = "Search by:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new System.Drawing.Point(368, 144);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new System.Drawing.Size(329, 31);
            searchTextBox.TabIndex = 8;
            // 
            // clearBtn
            // 
            clearBtn.Location = new System.Drawing.Point(909, 135);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new System.Drawing.Size(112, 48);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(399, 222);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(279, 51);
            button2.TabIndex = 10;
            button2.Text = "View Bookings";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(766, 222);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(255, 51);
            button3.TabIndex = 11;
            button3.Text = "View Accepted Bookings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(66, 222);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(251, 51);
            button4.TabIndex = 12;
            button4.Text = "Add Booking";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(753, 46);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(112, 54);
            button5.TabIndex = 13;
            button5.Text = "Edit Profile";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // UserHomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1061, 600);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(clearBtn);
            Controls.Add(searchTextBox);
            Controls.Add(label2);
            Controls.Add(searchComboBox);
            Controls.Add(searchBtn);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(label1);
            Name = "UserHomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "UserHomePage";
            Load += UserHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}