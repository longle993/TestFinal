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

namespace TestManagement.GUI
{
    public partial class ListResult : Form
    {
        TestTimes time;
        Test test;
        public ListResult()
        {
            InitializeComponent();

        }
        public ListResult(Test test)
        {
            InitializeComponent();
            this.test = test;

        }

        private void ListResult_Load(object sender, EventArgs e)
        {
            time = new TestTimes();
            time.TestDate = DateTime.Now;
            time.TestID = test.TestID;
            time.TestName = test.TestName;
            Random rd = new Random();
            time.CodeTest = rd.Next(100000, 999999).ToString();
            lblTesttimeID.Text = time.CodeTest;
            TestTimes_BUS.Instance.AddTestTimes(time);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
