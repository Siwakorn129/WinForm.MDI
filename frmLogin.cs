using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.MDI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //==property สำหรับค่าที่ได้จากการ login
        public int EmployeeID { get; set; }
        public string Empname { get; set; }
        public string Position { get; set; }
        public string UserName { get; set; }

        //connect database
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmployeeID = 0;
            Empname = string.Empty;
            Position = string.Empty;
            UserName = string.Empty;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = "select EmployeeID, Empname = Title+FirstName+' '+LastName, Position, Username from employees where Username = @username and Password =@password ";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count==1)
            {
                EmployeeID = Convert.ToInt16(ds.Tables[0].Rows[0]["EmployeeID"]);
                Empname = ds.Tables[0].Rows[0]["EmpName"].ToString();
                Position = ds.Tables[0].Rows[0]["Position"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                MessageBox.Show(EmployeeID + Environment.NewLine + Empname + Environment.NewLine + Position, "ยินดีต้อนรับ");
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง", "เกิดข้อผืดพลาด");
                EmployeeID = 0;
                Empname = string.Empty;
                Position = string.Empty;
                UserName = string.Empty;
            }
            this.Close();
        }
    }
}
