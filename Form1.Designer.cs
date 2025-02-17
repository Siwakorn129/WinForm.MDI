namespace WinForm.MDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuLogin = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            mnuProduct = new ToolStripMenuItem();
            mnuCategory = new ToolStripMenuItem();
            mnuEmployee = new ToolStripMenuItem();
            mnu = new ToolStripMenuItem();
            mnuManagerLogout = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            mnuSaleproduct = new ToolStripMenuItem();
            mnuSaleReport = new ToolStripMenuItem();
            mnuSaleLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(1084, 453);
            button1.Name = "button1";
            button1.Size = new Size(96, 80);
            button1.TabIndex = 0;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(1065, 307);
            button2.Name = "button2";
            button2.Size = new Size(115, 85);
            button2.TabIndex = 1;
            button2.Text = "logout";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1096, 406);
            label1.Name = "label1";
            label1.Size = new Size(84, 44);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuLogin, mnuExit });
            menuStrip1.Location = new Point(0, 104);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1203, 52);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuLogin
            // 
            mnuLogin.Name = "mnuLogin";
            mnuLogin.Size = new Size(132, 48);
            mnuLogin.Text = "เข้าสู่ระบบ";
            mnuLogin.Click += mnuLogin_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(150, 48);
            mnuExit.Text = "ปิดโปรแกรม";
            mnuExit.Click += mnuExit_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnuProduct, mnuCategory, mnuEmployee, mnu, mnuManagerLogout });
            menuStrip2.Location = new Point(0, 52);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1203, 52);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // mnuProduct
            // 
            mnuProduct.Name = "mnuProduct";
            mnuProduct.Size = new Size(203, 48);
            mnuProduct.Text = "จัดการข้อมูลสินค้า";
            mnuProduct.Click += mnuProduct_Click;
            // 
            // mnuCategory
            // 
            mnuCategory.Name = "mnuCategory";
            mnuCategory.Size = new Size(288, 48);
            mnuCategory.Text = "จัดการข้อมูลหมวดหมู่สินค้า";
            mnuCategory.Click += mnuCategory_Click;
            // 
            // mnuEmployee
            // 
            mnuEmployee.Name = "mnuEmployee";
            mnuEmployee.Size = new Size(231, 48);
            mnuEmployee.Text = "จัดการข้อมูลพนักงาน";
            // 
            // mnu
            // 
            mnu.Name = "mnu";
            mnu.Size = new Size(180, 48);
            mnu.Text = "รายงานการขาย";
            // 
            // mnuManagerLogout
            // 
            mnuManagerLogout.Name = "mnuManagerLogout";
            mnuManagerLogout.Size = new Size(163, 48);
            mnuManagerLogout.Text = "ออกจากระบบ";
            mnuManagerLogout.Click += mnuManagerLogout_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { mnuSaleproduct, mnuSaleReport, mnuSaleLogout });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1203, 52);
            menuStrip3.TabIndex = 6;
            menuStrip3.Text = "menuStrip3";
            // 
            // mnuSaleproduct
            // 
            mnuSaleproduct.Name = "mnuSaleproduct";
            mnuSaleproduct.Size = new Size(124, 48);
            mnuSaleproduct.Text = "ขายสินค้า";
            mnuSaleproduct.Click += mnuSaleproduct_Click;
            // 
            // mnuSaleReport
            // 
            mnuSaleReport.Name = "mnuSaleReport";
            mnuSaleReport.Size = new Size(184, 48);
            mnuSaleReport.Text = "รายงานยอดขาย";
            mnuSaleReport.Click += mnuSaleReport_Click;
            // 
            // mnuSaleLogout
            // 
            mnuSaleLogout.Name = "mnuSaleLogout";
            mnuSaleLogout.Size = new Size(163, 48);
            mnuSaleLogout.Text = "ออกจากระบบ";
            mnuSaleLogout.Click += mnuSaleLogout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 588);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem mnuLogin;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuProduct;
        private ToolStripMenuItem mnuCategory;
        private ToolStripMenuItem mnuEmployee;
        private ToolStripMenuItem mnu;
        private ToolStripMenuItem mnuManagerLogout;
        private ToolStripMenuItem mnuSaleproduct;
        private ToolStripMenuItem mnuSaleReport;
        private ToolStripMenuItem mnuSaleLogout;
    }
}
