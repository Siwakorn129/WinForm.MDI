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
    }
}
