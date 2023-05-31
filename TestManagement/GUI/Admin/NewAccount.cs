using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.BUS;
using TestManagement.DTO;
using TestManagement.UserControl_Test;

namespace TestManagement.GUI
{
    public partial class NewAccount : Form
    {
        #region Set chiều cao cho ComboBox
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        private const Int32 CB_SETITEMHEIGHT = 0x153;
        private void SetComboBoxHeight(IntPtr comboBoxHandle, Int32 comboBoxDesiredHeight)
        {
            SendMessage(comboBoxHandle, CB_SETITEMHEIGHT, -1, comboBoxDesiredHeight);
        }
        #endregion

        public NewAccount()
        {
            InitializeComponent();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            SetComboBoxHeight(cbboxPhanQuyen.Handle, 30);
            cbboxPhanQuyen.Refresh();
        }

        private void txtConfirm__TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Texts != txtConfirm.Texts)
            {
                lblPassCheck.Visible = true; return;
            }
            lblPassCheck.Visible = false;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (lblCheckUserName.Visible == true || lblCheckMail.Visible == true || lblPassCheck.Visible == true ||cbboxPhanQuyen.Text is null || cbboxPhanQuyen.Text == "")
            {
                MessageBox.Show("Thông tin đăng ký chưa hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            Account account = new Account();
            account.Email = txtEmail.Texts;
            account.UserName = txtUserName.Texts;
            account.Password = txtPass.Texts;
            account.Decentralization = cbboxPhanQuyen.Text;
            Account_BUS.Instance.AddAccount(account);
            MessageBox.Show("Đăng ký thành công");
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (Account_BUS.Instance.CheckUserName(txtUserName.Texts) == null)
            {
                lblCheckUserName.Visible = false; return;
            }
            lblCheckUserName.Visible = true;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Account_BUS.Instance.CheckEmail(txtEmail.Texts) == null)
            {
                lblCheckMail.Visible = false; return;
            }
            lblCheckMail.Visible = true;
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

        private void picHidePass_Click(object sender, EventArgs e)
        {
            ShowHidePass(txtPass, picHidePass);
        }

        private void picHidePass2_Click(object sender, EventArgs e)
        {
            ShowHidePass(txtConfirm, picHidePass2);
        }
    }
}
