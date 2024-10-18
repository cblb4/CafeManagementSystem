namespace CafeManagementSystem
{
    partial class CashierMainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.customer_btn = new System.Windows.Forms.Button();
            this.order_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddProducts1 = new CafeManagementSystem.AdminAddProducts();
            this.adminDashboardForm1 = new CafeManagementSystem.AdminDashboardForm();
            this.cashierOrder1 = new CafeManagementSystem.CashierOrder();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.customer_btn);
            this.panel2.Controls.Add(this.order_btn);
            this.panel2.Controls.Add(this.menu_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 738);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::CafeManagementSystem.Properties.Resources.bREWED__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(20, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 204);
            this.panel4.TabIndex = 30;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logout_btn.Location = new System.Drawing.Point(20, 664);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(215, 49);
            this.logout_btn.TabIndex = 29;
            this.logout_btn.Text = "LOG OUT";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customer_btn.Location = new System.Drawing.Point(20, 485);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(215, 49);
            this.customer_btn.TabIndex = 28;
            this.customer_btn.Text = "Customers";
            this.customer_btn.UseVisualStyleBackColor = true;
            // 
            // order_btn
            // 
            this.order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.order_btn.Location = new System.Drawing.Point(20, 419);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(215, 49);
            this.order_btn.TabIndex = 27;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = true;
            // 
            // menu_btn
            // 
            this.menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu_btn.Location = new System.Drawing.Point(20, 352);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(215, 49);
            this.menu_btn.TabIndex = 26;
            this.menu_btn.Text = "Menu";
            this.menu_btn.UseVisualStyleBackColor = true;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_btn.Location = new System.Drawing.Point(20, 285);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(215, 49);
            this.dashboard_btn.TabIndex = 25;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cashier\'s Portal";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1197, 18);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 23);
            this.close.TabIndex = 23;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 61);
            this.panel1.TabIndex = 3;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(942, 18);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(28, 23);
            this.close_btn.TabIndex = 31;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cashierOrder1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.adminDashboardForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(251, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(992, 677);
            this.panel3.TabIndex = 4;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(169)))), ((int)(((byte)(127)))));
            this.adminAddProducts1.Location = new System.Drawing.Point(-10, -4);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1023, 681);
            this.adminAddProducts1.TabIndex = 1;
            // 
            // adminDashboardForm1
            // 
            this.adminDashboardForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(169)))), ((int)(((byte)(127)))));
            this.adminDashboardForm1.Location = new System.Drawing.Point(-10, 0);
            this.adminDashboardForm1.Name = "adminDashboardForm1";
            this.adminDashboardForm1.Size = new System.Drawing.Size(1023, 681);
            this.adminDashboardForm1.TabIndex = 0;
            // 
            // cashierOrder1
            // 
            this.cashierOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(169)))), ((int)(((byte)(127)))));
            this.cashierOrder1.Location = new System.Drawing.Point(-16, -4);
            this.cashierOrder1.Name = "cashierOrder1";
            this.cashierOrder1.Size = new System.Drawing.Size(1023, 681);
            this.cashierOrder1.TabIndex = 2;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1243, 738);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierMainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button close_btn;
        private AdminAddProducts adminAddProducts1;
        private AdminDashboardForm adminDashboardForm1;
        private CashierOrder cashierOrder1;
    }
}