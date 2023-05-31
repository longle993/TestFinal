﻿using System;
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
using TestManagement.UserControl_Test;

namespace TestManagement.GUI
{
    public partial class ListTest : Form
    {
        List<Test> tests;
        List<TestDetail> testDetails;
        List<Question> questions;
        FormMain formMain;

        public ListTest()
        {
            InitializeComponent();
        }
        public ListTest(FormMain formMain)
        {
            InitializeComponent();
            questions = new List<Question>();
            this.formMain = formMain;
            formMain.btnTongquan.Click += BtnTongquan_Click;
        }

        private void BtnTongquan_Click(object sender, EventArgs e)
        {
            this.Close();
            formMain.panellFile.Visible = true;
            formMain.panelDetail.Visible = true;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            sortedList.Visible = !sortedList.Visible;
        }
        private void LoadInfoTest()
        {
            Test test = Test_BUS.Instance.FindByName(lblFileName.Text);
            lblDescription.Text = test.Description;
        }
        private void LblfolderName_ClickTest(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            lblFileName.Text = control.Tag.ToString();
            panelButtonDetail.Visible = true;
            picIconDetail.Image = Properties.Resources.Folder;
            LoadInfoTest();

        }

        private void Listtest_Click(object sender, EventArgs e)
        {
            ListFolder listFolder = (ListFolder)sender;
            lblFileName.Text = listFolder.Tag.ToString();
            panelButtonDetail.Visible = true;
            picIconDetail.Image = Properties.Resources.File;
            LoadInfoTest();

        }
        private void LoadListTest()
        {
            flowTest.Controls.Clear();
            foreach (Test test in tests)
            {
                ListFolder listtest = new ListFolder();
                listtest.FolderName = test.TestName;
                listtest.CreatedDay = test.InitiationDate.ToString("dd/MM/yyyy");
                listtest.ChangedDay = test.ChangedDate.ToString("dd/MM/yyyy");
                listtest.Icon = Properties.Resources.File;

                listtest.Click += Listtest_Click;
                listtest.lblfolderName.Click += LblfolderName_ClickTest;
                listtest.lblChangedDay.Click += LblfolderName_ClickTest;
                listtest.lblcreatedDay.Click += LblfolderName_ClickTest;
                flowTest.Controls.Add(listtest);
            }
        }

        private void ListTest_Load(object sender, EventArgs e)
        {
            tests = Test_BUS.Instance.GetListTest();
            LoadListTest();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xoá bài kiểm tra này đồng nghĩa với xoá các thông tin liên quan bao gồm cả bảng điểm và các lần thi. Bạn có chắc chắn muốn xoá?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Test test = tests.SingleOrDefault(p => p.TestName == lblFileName.Text);
                testDetails = TestDetail_BUS.Instance.GetTestDetails(test.TestID);
                foreach (TestDetail detail in testDetails)
                {
                    Question question = Question_BUS.Instance.GetQuestion(detail.QuestionID);
                    questions.Add(question);
                    Answer_BUS.Instance.DelAnswer(question);
                }
                TestDetail_BUS.Instance.DelTestDetail(testDetails);
                Question_BUS.Instance.DelQuestion(questions);

                List<TestTimes> testTimes = TestTimes_BUS.Instance.GetTestTimes(test);
                foreach(TestTimes testTimes1 in testTimes)
                {
                    Result_BUS.Instance.DelResult(testTimes1);
                }
                TestTimes_BUS.Instance.DelTestTimes(testTimes);
                Test_BUS.Instance.DelTest(test);
                tests = Test_BUS.Instance.GetListTest();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListTest();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Test test = Test_BUS.Instance.FindByName(lblFileName.Text);
            if (test is null)
            {
                MessageBox.Show("Chọn bài Test để bắt đầu kiểm tra","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
            else
            {
                StartTest startTest = new StartTest(test);
                this.Hide();
                startTest.ShowDialog();
                this.Show();
            }    

        }
    }
}