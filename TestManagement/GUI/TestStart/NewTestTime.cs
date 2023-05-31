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

namespace TestManagement.GUI.StartTest
{
    public partial class NewTestTime : Form
    {
        Test test;
        string testname;
        public NewTestTime()
        {
            InitializeComponent();
        }
        public NewTestTime(string testname)
        {
            InitializeComponent();
            this.testname=testname;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            test=Test_BUS.Instance.FindByName(testname);
            if (txtTestName.Texts.Length>0 && txtCode.Texts.Length>0)
            {
                TestTimes testTimes = new TestTimes();
                testTimes.TestName=txtTestName.Texts;
                testTimes.CodeTest=txtCode.Texts;
                testTimes.TestID=test.TestID;
                testTimes.TestDate=DateTime.Now;
                TestTimes_BUS.Instance.AddTestTimes(testTimes);
                MessageBox.Show("Tạo bài kiểm tra thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
