using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.BUS;
using TestManagement.DTO;
using TestManagement.GUI.HomePage;

namespace TestManagement.GUI
{
    public partial class Infomation : Form
    {
        string code;
        TestTimes testTimes;
        Test test;
        public Infomation()
        {
            InitializeComponent();
        }
        public Infomation(string code)
        {
            InitializeComponent();
            this.code = code;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtID.Texts.Length>0 && txtName.Texts.Length>0)
            {
                testTimes = TestTimes_BUS.Instance.GetTestTime(code);
                if (testTimes != null)
                {
                    test=Test_BUS.Instance.FindByID(testTimes.TestID);
                    StartTest startTest = new StartTest(test, txtName.Texts, txtID.Texts, testTimes);
                    this.Hide();
                    startTest.ShowDialog();
                    this.Show();
                }
                else if (testTimes==null)
                {
                    MessageBox.Show("Mã phòng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin để vào thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
