namespace WinForm.MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            if (f.EmployeeID == 0)//in case faile pass
            {
                return;
            }
            label1.Text += f.EmployeeID.ToString() + Environment.NewLine;
            label1.Text += f.Empname + Environment.NewLine;
            label1.Text += f.Position + Environment.NewLine;
            label1.Text += f.UserName;
            this.Text = "ชื่อผู้ใช้ :" + f.Empname + "ตำแหน่ง :" + f.Position;
            button1.Visible = false;//hidelogin
            button2.Visible = true;//show cancel
            label1.Visible = true;//show label1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //show menu
            ShowHideMenu(true, false, false);
        }

        void ShowHideMenu(Boolean Start, Boolean mgrMenu, Boolean saleMenu)
        {
            menuStrip1.Visible = Start;
            menuStrip2.Visible = mgrMenu;
            menuStrip3.Visible = saleMenu;
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            if (f.EmployeeID == 0)//in case faile pass
            {
                return;
            }

            this.Text = "ชื่อผู้ใช้ :" + f.Empname + "ตำแหน่ง :" + f.Position;
            if (f.Position == "Sale Manager")
            {
                ShowHideMenu(false, true, false);
            }
            else if (f.Position == "Sale Representative")
            {
                ShowHideMenu(false, false, true);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ปิดโปรแกรม", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;//click no willclose
            }
        }

        private void mnuSaleproduct_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSaleReport_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuProduct_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSaleLogout_Click(object sender, EventArgs e)
        {
            //if logout close form
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
            ShowHideMenu(true, false, false);
            this.Text = "ระบบ MiniMart";
        }

        private void mnuManagerLogout_Click(object sender, EventArgs e)
        {
            //if logout close form
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
            ShowHideMenu(true, false, false);
            this.Text = "ระบบ MiniMart";
        }
    }
}
