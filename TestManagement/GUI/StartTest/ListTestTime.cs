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
using TestManagement.GUI.FormReport;
using TestManagement.Report;
using TestManagement.UserControl_Test;

namespace TestManagement.GUI
{
    public partial class ListTestTime : Form
    {
        Test test = new Test();
        List<TestTimes> testTimes;
        ConnectingData db = new ConnectingData();
        private Form currentChildForm;
        public ListTestTime()
        {
            InitializeComponent();
        }
        public ListTestTime(string name)
        {
            InitializeComponent();
            this.test=Test_BUS.Instance.FindByName(name);
        }
        private void ListTest_Load(object sender, EventArgs e)
        {
            LoadListTestTime();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //sortedList.Visible = !sortedList.Visible;
        }
        private void LblfolderName_ClickTest(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            lblFileName.Text = control.Tag.ToString();
            panelButtonDetail.Visible = true;
            picIconDetail.Image = Properties.Resources.Folder;
        }
        private void Listtest_Click(object sender, EventArgs e)
        {
            ListFolder listFolder = (ListFolder)sender;
            lblFileName.Text = listFolder.Tag.ToString();
            panelButtonDetail.Visible = true;
            picIconDetail.Image = Properties.Resources.File;
        }
        private void LoadListTestTime()
        {
            flowTest.Controls.Clear();
            testTimes=TestTimes_BUS.Instance.GetTestTimes(test);
            foreach (TestTimes item in testTimes)
            {
                ListFolder listtest = new ListFolder();
                listtest.FolderName = item.TestName;
                listtest.CreatedDay = item.CodeTest;
                listtest.ChangedDay = item.TestDate.ToString("dd/MM/yyyy");
                listtest.Icon = Properties.Resources.File;

                listtest.Click += Listtest_Click;
                listtest.lblfolderName.Click += LblfolderName_ClickTest;
                listtest.lblChangedDay.Click += LblfolderName_ClickTest;
                listtest.lblcreatedDay.Click += LblfolderName_ClickTest;
                flowTest.Controls.Add(listtest);
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text!="FileName")
            {
                if (MessageBox.Show("Xoá bài kiểm tra này đồng nghĩa với xoá các thông tin liên quan bao gồm cả bảng điểm. Bạn có chắc chắn muốn xoá?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string name = lblFileName.Text;
                    TestTimes TestTimes = TestTimes_BUS.Instance.GetTestTimeByName(lblFileName.Text);
                    Result_BUS.Instance.DelResult(TestTimes);
                    TestTimes_BUS.Instance.DeleteTestTime(TestTimes);
                    lblFileName.Text = "FileName";
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListTestTime();
                }
            }
            else if (lblFileName.Text=="FileName")
            {
                MessageBox.Show("Hãy chọn bài Test để tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnResultTest_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text!="FileName")
            {
                var query = from subject in db.Subjects
                            join test in db.Tests on subject.SubjectID equals test.SubjectID
                            join testTimes in db.TestTimes on test.TestID equals testTimes.TestID
                            join result in db.Results on testTimes.TestTimesID equals result.TestTimesID
                            where testTimes.TestName == lblFileName.Text
                            select new
                            {
                                subject.SubjectName,
                                test.TestName,
                                testTimes.TestDate,
                                result.StudentName,
                                result.MSSV,
                                result.NumberCorrect,
                                result.Score
                            };

                var results = query.ToList();

                PrintResult printResult = new PrintResult();
                printResult.SetDataSource(results);

                ReportResult reportResult = new ReportResult();
                reportResult.crystalReportViewer1.ReportSource=printResult;
                reportResult.ShowDialog();
            }
            else if (lblFileName.Text=="FileName")
            {
                MessageBox.Show("Hãy chọn bài Test để tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Mở Form con
        public void OpenChildForm(Form childForm, Panel panel)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            //Add Form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

    }
}
