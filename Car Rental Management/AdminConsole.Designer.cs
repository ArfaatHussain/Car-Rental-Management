namespace Car_Rental_Management
{
    partial class AdminConsole
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
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.viewBookingBtn = new System.Windows.Forms.Button();
            this.viewPaymentBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Console";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(56, 161);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(189, 44);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 304);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(906, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(353, 161);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(189, 44);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(642, 161);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(189, 44);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // viewBookingBtn
            // 
            this.viewBookingBtn.Location = new System.Drawing.Point(56, 231);
            this.viewBookingBtn.Name = "viewBookingBtn";
            this.viewBookingBtn.Size = new System.Drawing.Size(327, 44);
            this.viewBookingBtn.TabIndex = 7;
            this.viewBookingBtn.Text = "View Bookings";
            this.viewBookingBtn.UseVisualStyleBackColor = true;
            this.viewBookingBtn.Click += new System.EventHandler(this.viewBookingBtn_Click);
            // 
            // viewPaymentBtn
            // 
            this.viewPaymentBtn.Location = new System.Drawing.Point(512, 231);
            this.viewPaymentBtn.Name = "viewPaymentBtn";
            this.viewPaymentBtn.Size = new System.Drawing.Size(319, 44);
            this.viewPaymentBtn.TabIndex = 8;
            this.viewPaymentBtn.Text = "View Payments";
            this.viewPaymentBtn.UseVisualStyleBackColor = true;
            this.viewPaymentBtn.Click += new System.EventHandler(this.viewPaymentBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(30, 33);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(98, 41);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AdminConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 609);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.viewPaymentBtn);
            this.Controls.Add(this.viewBookingBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Name = "AdminConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminConsole";
            this.Load += new System.EventHandler(this.AdminConsole_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button viewBookingBtn;
        private System.Windows.Forms.Button viewPaymentBtn;
        private System.Windows.Forms.Button backBtn;
    }
}