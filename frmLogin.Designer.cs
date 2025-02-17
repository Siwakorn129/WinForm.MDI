namespace WinForm.MDI
{
    partial class frmLogin
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
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 109);
            label1.Name = "label1";
            label1.Size = new Size(83, 44);
            label1.TabIndex = 0;
            label1.Text = "ชื่อผู้ใช้";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtUserName.Location = new Point(158, 102);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(291, 51);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtPassword.Location = new Point(158, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(291, 51);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 184);
            label2.Name = "label2";
            label2.Size = new Size(99, 44);
            label2.TabIndex = 2;
            label2.Text = "รหัสผ่าน";
            // 
            // btnOK
            // 
            btnOK.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            btnOK.Location = new Point(549, 77);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(171, 100);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            btnCancel.Location = new Point(549, 215);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 100);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "เข้าสู่ระบบ";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label2;
        private Button btnOK;
        private Button btnCancel;
    }
}