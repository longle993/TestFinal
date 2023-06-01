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
using TestManagement.GUI.HomePage;
using TestManagement.Report;
using TestManagement.UserControl_Test;

namespace TestManagement.GUI
{
    public partial class ListTest : Form
    {
        List<Test> tests;
        FormMain formMain;
        ConnectingData db = new ConnectingData();
        private Form currentChildForm;
        public ListTest()
        {
            InitializeComponent();
        }
        public ListTest(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            formMain.btnTongquan.Click += BtnTongquan_Click;
        }
        private void ListTest_Load(object sender, EventArgs e)
        {
            tests = Test_BUS.Instance.GetListTest();
            LoadListTest();
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

                //ADD TAG
                listtest.picIcon.Tag = test.TestName;
                listtest.lblfolderName.Tag = test.TestName;
                listtest.lblcreatedDay.Tag = test.TestName;
                listtest.lblChangedDay.Tag = test.TestName;

                //ADD EVENT
                listtest.Click += Listtest_Click;

                listtest.lblfolderName.Click += LblfolderName_ClickTest;
                listtest.lblChangedDay.Click += LblfolderName_ClickTest;
                listtest.lblcreatedDay.Click += LblfolderName_ClickTest;
                listtest.picIcon.Click += LblfolderName_ClickTest;
                flowTest.Controls.Add(listtest);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text!="FileName")
            {
                NewTestTime newTestTime = new NewTestTime(lblFileName.Text);
                newTestTime.ShowDialog();
                lblFileName.Text="FileName";
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
                            where test.TestName == lblFileName.Text
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
                lblFileName.Text="FileName";
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

        private void btnOpenTest_Click(object sender, EventArgs e)
        {
            string name = lblFileName.Text;
            ListTestTime listTestTime = new ListTestTime(name);
            listTestTime.ShowDialog();
            lblFileName.Text="FileName";
        }
    }
}