using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.UserControl_Test;
using System.Windows.Forms;
using TestManagement.BUS;
using TestManagement.DTO;

namespace TestManagement.GUI
{
    public partial class ResetPass : Form
    {
        string email;
        SendOTP SendOTP;
        string table = "UPDATE_ACCOUNT new password";
        DateTime timeOpenApplication = DateTime.Now;
        public ResetPass()
        {
            InitializeComponent();
        }

        public ResetPass(string email,SendOTP sendOTP)
        {
            InitializeComponent();
            UPDATE_CHECK.SetTable(table);
            this.email = email;
            this.SendOTP = sendOTP;
        }

        private void txtPassConfirm__TextChanged(object sender, EventArgs e)
        {
            if(txtNewPass.Texts != txtPassConfirm.Texts)
            {
                lblPassCheck.Visible = true;
            }
            else
            {
                lblPassCheck.Visible = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UPDATE_CHECK.NotifyChange(table);
            if(lblPassCheck.Visible == true)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Account_BUS.Instance.UpdateAccount(email, txtNewPass.Texts);
            StartTimerAsync();
            SendOTP.Close();
            this.Close();

        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            ShowHidePass(txtNewPass, picHidePass);
        }
        private void picHidePass2_Click(object sender, EventArgs e)
        {
            ShowHidePass(txtPassConfirm, picHidePass2);
        }
        private void ShowHidePass(TextBox_Advanced txt, PictureBox pic)
        {
            if (txt.PasswordChar == true)
            {
                txt.PasswordChar = false;
                pic.Image = Properties.Resources.eye;
                return;
            }
            else if (txt.PasswordChar == false)
            {
                txt.PasswordChar = true;
                pic.Image = Properties.Resources.eyeslash;
                return;
            }
        }
        #region Kiểm tra cập nhật RealTime
        private void StartTimerAsync()
        {
            var res = UPDATE_CHECK.Client.Get(@"Update/" + table);
            UPDATE_CHECK check = res.ResultAs<UPDATE_CHECK>();
            if (timeOpenApplication < DateTime.Parse(check.DateTimeUpdate))
            {
                MessageBox.Show("Cập nhật thành công");
                timeOpenApplication = DateTime.Now;
            }
        }
        #endregion
    }
}
