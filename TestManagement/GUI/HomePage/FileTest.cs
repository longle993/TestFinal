using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.UserControl_Test;
using TestManagement.DTO;
using TestManagement.BUS;

using System.Windows.Forms;
using TestManagement.GUI.FormReport;
using TestManagement.Report;

namespace TestManagement.GUI
{
    public partial class FileTest : Form
    {
        private Form currentChildForm;
        string subjectName;
        List<Test> tests;
        List<TestDetail> testDetails;
        List<Question> questions;
        FormMain formMain;
        ConnectingData db = new ConnectingData();

        public FileTest()
        {
            InitializeComponent();
        }
        public FileTest(string subjectName,FormMain formMain)
        {
            InitializeComponent();
            this.subjectName = subjectName;
            this.sortedList.btnAtoZ.Click += BtnAtoZ_Click;
            this.sortedList.btnZtoA.Click += BtnZtoA_Click;
            this.sortedList.btnChange.Click += BtnChange_Click;
            this.sortedList.btnNewest.Click += BtnNewest_Click;
            this.sortedList.btnOldest.Click += BtnOldest_Click;
            this.formMain = formMain;
        }

        private void FileTest_Load(object sender, EventArgs e)
        {
            tests = Test_BUS.Instance.GetTests(subjectName);
            LoadTest();
        }

        private void LoadTest()
        {
            flowTest.Controls.Clear();
            foreach (Test tes in tests)
            {
                ListFolder list = new ListFolder();
                list.FolderName = tes.TestName;
                list.CreatedDay = tes.InitiationDate.ToString("dd/MM/yyyy");
                list.ChangedDay = tes.ChangedDate.ToString("dd/MM/yyyy");
                list.Icon = Properties.Resources.File;

                list.Click += List_Click;
                list.lblfolderName.Click += LblfolderName_Click;
                flowTest.Controls.Add(list);
            }
        }

        private void LoadInfoTest()
        {
            Test test = Test_BUS.Instance.FindByName(lblFileName.Text);
            lblDescription.Text = test.Description;
        }
        private void LblfolderName_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            lblFileName.Text = control.Tag.ToString();
            panelButtonDetail.Visible = true;
            picIconDetail.Image = Properties.Resources.Folder;
            LoadInfoTest();
        }

        private void List_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            lblFileName.Text = control.Tag.ToString();
            panelButtonDetail.Visible = true;
            picIconDetail.Image = Properties.Resources.Folder;
            LoadInfoTest();

        }

        private void sortedList_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = !sortedList.Visible;
        }
        #region Show/Hide DropDown

        private void panellFile_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            this.btnNewTest.Visible = false;

        }
        private void panelTongquan_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            this.btnNewTest.Visible = false;

        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            sortedList.Visible = !sortedList.Visible;
            this.btnNewTest.Visible = false;

        }
        private void btnMore_Click(object sender, EventArgs e)
        {

        }


        #endregion
        #region sortedList
        private void BtnChange_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            tests = Test_BUS.Instance.SortedChange();
            flowTest.Controls.Clear();
            LoadTest();
        }

        private void BtnNewest_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            flowTest.Controls.Clear();
            tests = Test_BUS.Instance.SortedNewest();
            LoadTest();
        }

        private void BtnOldest_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            flowTest.Controls.Clear();
            tests = Test_BUS.Instance.SortedOldest();
            LoadTest();
        }

        private void BtnZtoA_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            flowTest.Controls.Clear();
            tests = Test_BUS.Instance.SortedZtoA();
            LoadTest();
        }
        private void BtnAtoZ_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            flowTest.Controls.Clear();
            tests = Test_BUS.Instance.SortedAtoZ();
            LoadTest();
        }

        #endregion

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            NewTest newTest = new NewTest();
            newTest.ShowDialog();
        }

        private void btnTongquan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Mở Form con
        public void OpenChildForm(Form childForm)
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
            panelTest.Controls.Add(childForm);
            panelTest.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        #endregion

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
                foreach (TestTimes testTimes1 in testTimes)
                {
                    Result_BUS.Instance.DelResult(testTimes1);
                }
                TestTimes_BUS.Instance.DelTestTimes(testTimes);
                Test_BUS.Instance.DelTest(test);
                tests = Test_BUS.Instance.GetListTest();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTest();
            }
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            Test test = Test_BUS.Instance.FindByName(lblFileName.Text);
            OpenChildForm(new CreateTest(test));
        }

        private void btnTest_Click(object sender, EventArgs e)
        {           
            panelDetail.Visible = false;
            panellFile.Visible = false;
            OpenChildForm(new ListTest(formMain));           
        }

        private void button_Advanced3_Click(object sender, EventArgs e)
        {
            var query = from subject in db.Subjects
                        join test in db.Tests on subject.SubjectID equals test.SubjectID
                        join testDetail in db.TestDetails on test.TestID equals testDetail.TestID
                        join question in db.Questions on testDetail.QuestionID equals question.QuestionID
                        join answer in db.Answers on question.QuestionID equals answer.QuestionID
                        where test.TestName == "Science Test 1"
                        group new { subject, test, question, answer } by new { subject.SubjectName, test.TestName, question.QuestionText } into groupedData
                        select new
                        {
                            SubjectName = groupedData.Key.SubjectName,
                            TestName = groupedData.Key.TestName,
                            QuestionText = groupedData.Key.QuestionText,
                            Answers = groupedData.Select(x => x.answer.AnswerText)
                        };
            var result = query.ToList();

            var finalResult = result.Select(x => new {
                x.SubjectName,
                x.TestName,
                x.QuestionText,
                AnswerText = string.Join("\n\n", x.Answers)
            }).ToList();
            //var result = "Select SubjectName,Test.TestName,QuestionText,AnswerText,Test.TestTime From Subject Inner Join Test On Subject.SubjectID=Test.SubjectID Inner Join TestDetail On Test.TestID=TestDetail.TestID Inner Join Question On TestDetail.QuestionID=Question.QuestionID Inner Join Answer On Question.QuestionID=Answer.QuestionID";
            PrintTest printTest = new PrintTest();
            printTest.SetDataSource(finalResult);
            ReportTest reportTest = new ReportTest();
            reportTest.crystalReportViewer2.ReportSource=printTest;
            reportTest.ShowDialog();
        }
    }
}
