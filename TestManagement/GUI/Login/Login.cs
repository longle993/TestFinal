using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.BUS;
using TestManagement.DTO;
using TestManagement.GUI;

namespace TestManagement
{
    public partial class Login : Form
    {
        private Form currentChildForm;
        string table = "CHECK_ACCOUNT Verify"; //Lệnh cập nhật Firebase
        DateTime timeOpenApplication = DateTime.Now; //Thời gian bắt đầu mở hệ thống
        public Login()
        {
            InitializeComponent();
            UPDATE_CHECK.SetTable(table); //Đặt thông báo cập nhật
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Cập nhật thời gian thực hiện đăng nhập
            UPDATE_CHECK.NotifyChange(table);
            //Chuyển đổi mật khẩu đã nhập sang mã MD5
            string encodePass = ConvertToMD5(txtPass.Texts);

            //Kiểm tra tài khoản và mật khẩu
            if(Account_BUS.Instance.CheckAccount(txtUserName.Texts,txtPass.Texts) == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            StartTimerAsync();//Cập nhật kiểm tra thành công lên Firebase
            //Mở Form chính
            FormMain form1 = new FormMain();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
        private void picHidePass_Click(object sender, EventArgs e)
        {
            //Nếu ô nhập mật khẩu ở chế độ ẩn Password thì đổi sang hiện password và đổi hình ảnh thành eye. Và ngược lại
            if(txtPass.PasswordChar == true)
            {
                txtPass.PasswordChar = false;
                picHidePass.Image = Properties.Resources.eye;
                return;
            }
            else if(txtPass.PasswordChar == false)
            {
                txtPass.PasswordChar = true;
                picHidePass.Image = Properties.Resources.eyeslash;
                return;
            }
            
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            //Mở Form Gửi OTP
            OpenChildForm(new SendOTP());
        }
        private string ConvertToMD5(string s)
        {
            //Tạo StringBuilder để xây dựng chuỗi kết quả
            StringBuilder sb = new StringBuilder();

            using (MD5 md5 = MD5.Create())
            {
                //Chuyển đổi chuỗi s thành MD5
                byte[] hashValue = md5.ComputeHash(Encoding.UTF8.GetBytes(s));

                //Nối chuỗi s vào sb
                foreach (byte b in hashValue)
                {
                    sb.Append($"{b:X2}");
                }
            }
            return sb.ToString();
        }


        #region Mở Form con
        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSendOTP.Controls.Add(childForm);
            panelSendOTP.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Kiểm tra cập nhật RealTime
        private void StartTimerAsync()
        {
            var res = UPDATE_CHECK.Client.Get(@"Update/" + table);
            UPDATE_CHECK check = res.ResultAs<UPDATE_CHECK>();
            if (timeOpenApplication < DateTime.Parse(check.DateTimeUpdate))
            {
                timeOpenApplication = DateTime.Now;
            }
        }
        #endregion

    }
}
