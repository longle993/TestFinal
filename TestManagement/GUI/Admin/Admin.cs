using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.DTO;
using TestManagement.BUS;
using TestManagement.UserControl_Test;

namespace TestManagement.GUI
{
    public partial class Admin : Form
    {
        List<Account> dsAccount;
        FormMain formMain;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            Task task1 = new Task(FormAdminTrue);
            task1.RunSynchronously();
            this.formMain.btnBack.Click += BtnBack_Click;
        }

        private void TxtSearch__TextChanged(object sender, EventArgs e)
        {
            dsAccount = Account_BUS.Instance.FindByUserName(formMain.txtSearch.Texts);
            flowAccount.Controls.Clear();
            LoadGrid();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Task task1 = new Task(FormAdminFalse);
            Task task2 = new Task(this.Close);
            task1.RunSynchronously();
            task2.RunSynchronously();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dsAccount = Account_BUS.Instance.GetAccounts();
            LoadGrid();
        }
        private void LoadGrid()
        {
            foreach(Account acc in dsAccount)
            {
                DataAccount dataAccount = new DataAccount();
                dataAccount.lblUserName.Text = acc.UserName;
                dataAccount.lblMail.Text = acc.Email;
                dataAccount.lblPass.Text = acc.Password;
                dataAccount.lblPhanQuyen.Text = acc.Decentralization;
                flowAccount.Controls.Add(dataAccount);
            }
        }

        private void FormAdminTrue()
        {
            formMain.btnBack.Visible = true;
            formMain.txtSearch.PlaceholderText = "Tìm kiếm tài khoản...";
            //Thay đổi sự kiện của thanh Tìm kiếm
            this.formMain.txtSearch._TextChanged += TxtSearch__TextChanged;
        }

        private void FormAdminFalse()
        {
            formMain.btnBack.Visible = false;
            formMain.txtSearch.PlaceholderText = "Tìm kiếm bài kiểm tra...";
        }

        private void btnAddFolder_MouseEnter(object sender, EventArgs e)
        {
            this.btnAddAccount.BackColor = Color.Silver;
        }

        private void btnAddFolder_MouseLeave(object sender, EventArgs e)
        {
            this.btnAddAccount.BackColor = Color.White;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            NewAccount account = new NewAccount();
            account.ShowDialog();

        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            btnAddAccount.Visible = !btnAddAccount.Visible;
        }

        private void panel_Advanced1_Click(object sender, EventArgs e)
        {
            btnAddAccount.Visible = false;
        }

        private void flowAccount_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
