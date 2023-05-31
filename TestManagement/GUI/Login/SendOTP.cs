using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.BUS;
using TestManagement.DTO;

namespace TestManagement.GUI
{
    public partial class SendOTP : Form
    {
        string OTP = "XYZ"; 
        private Form currentChildForm;
        Timer timer;
        int timeRemaining;
        int timeDuration = 60;
        public SendOTP()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }
        #region Đếm ngược thời gian OTP
        private void StartTimer()
        {
            timeRemaining = timeDuration;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            if (timeRemaining == 0)
            {
                timer.Stop();
                btnSendOTP.Enabled = true;
                btnSendOTP.Invoke((MethodInvoker)(() => btnSendOTP.Text = "Gửi mã"));
                OTP = "XYZ";
            }
            else
            {
                btnSendOTP.Enabled = false;
                btnSendOTP.Invoke((MethodInvoker)(() => btnSendOTP.Text = timeRemaining.ToString()));
            }
        }
        #endregion

        #region Mở Form con
        private void OpenChildForm(Form childForm)
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
            panelResetPass.Controls.Add(childForm);
            panelResetPass.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Gửi OTP qua Mail
        private void SendEmail()
        {
            string senderEmail = "testmanagement.se002@gmail.com"; //Mail hệ thống
            string senderPassword = "fvbqyulhsjrjhldh";//Mã được lấy từ xác thực 2 yếu tố
            string recipientEmail = txtEmail.Texts;//Mail người nhận

            Random rd = new Random();
            this.OTP = rd.Next(100000, 999999).ToString();
            try
            {
                //Cấu hình gửi mail
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                string body = "<div style=\"font-family: Helvetica,Arial,sans-serif;min-width:1000px;overflow:auto;line-height:2\">\r\n  <div style=\"margin:50px auto;width:70%;padding:20px 0\">\r\n    <div style=\"border-bottom:1px solid #eee\">\r\n      <a href=\"\" style=\"font-size:1.4em;color: #00466a;text-decoration:none;font-weight:600\">Test Management</a>\r\n    </div>\r\n    <p style=\"font-size:1.1em\">Xin chào,</p>\r\n    <p>Đây là thư tự động gửi vào email. Vui lòng không trả lời thư này.<br> Dưới đây là mã OTP của bạn!</p>\r\n    <h2 style=\"background: #00466a;margin: 0 auto;width: max-content;padding: 0 10px;color: #fff;border-radius: 4px;\">" + OTP + "</h2>\r\n    <p style=\"font-size:0.9em;\">Xin cảm ơn,<br />Test Management</p>\r\n    <hr style=\"border:none;border-top:1px solid #eee\" />\r\n    <div style=\"float:right;padding:8px 0;color:#aaa;font-size:0.8em;line-height:1;font-weight:300\">\r\n    </div>\r\n  </div>\r\n</div>";
                string subject = "Đặt lại mật khẩu từ ứng dụng Test Management";
                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, body);
                mailMessage.IsBodyHtml = true;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
        #endregion

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if(Account_BUS.Instance.CheckEmail(txtEmail.Texts) == null)
            {
                this.lblEmailCheck.Visible = true;
                return;
            }
            SendEmail();
            MessageBox.Show("Đã gửi OTP, vui lòng check Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblEmailCheck.Visible = false;
            StartTimer();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtConfirm.Texts == OTP)
            {
                OpenChildForm(new ResetPass(txtEmail.Texts,this));
                lblError.Visible = false;
                timer.Stop();
            }
            else
            {
                lblError.Visible = true;
            }
        }


    }
}
