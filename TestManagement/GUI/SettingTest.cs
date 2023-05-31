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
using TestManagement.GUI.HomePage;

namespace TestManagement.GUI
{
    public partial class SettingTest : Form
    {
        ListTest list;
        Test test;
        
        public SettingTest()
        {
            InitializeComponent();
        }
        public SettingTest(ListTest list, Test test)
        {
            InitializeComponent();
            this.list = list;
            this.test = test;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ListResult result = new ListResult();
           
            this.Close();
           /* StartTest startTest = new StartTest(test);
            this.Hide();
            startTest.ShowDialog();
            this.Show();*/
        }
    }
}
