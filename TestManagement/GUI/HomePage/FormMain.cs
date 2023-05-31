using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.UserControl_Test;
using TestManagement.GUI.HomePage;
using TestManagement.BUS;
using TestManagement.DTO;
using System.Data.SqlClient;
using TestManagement.Report;
using TestManagement.GUI.FormReport;
using System.Runtime.InteropServices;

namespace TestManagement.GUI
{
    public partial class FormMain : Form
    {
        #region DragForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private Form currentChildForm;
        List<Subject> subjects;
        List<Test> tests;
        List<TestDetail> testDetails;
        List<Question> questions;
        ConnectingData db = new ConnectingData();
        public FormMain()
        {
            InitializeComponent();
            this.dropmenuAdmin.btnExit.Click += BtnExit_Click;
            this.dropmenuAdmin.btnQLTK.Click += BtnQLTK_Click;
            this.sortedList.Visible = false;


            //Cài đặt bộ lọc
            this.sortedList.btnAtoZ.Click += BtnAtoZ_Click;
            this.sortedList.btnZtoA.Click += BtnZtoA_Click;
            this.sortedList.btnOldest.Click += BtnOldest_Click;
            this.sortedList.btnNewest.Click += BtnNewest_Click;
            this.sortedList.btnChange.Click += BtnChange_Click;

            //Add Sự kiện cho dropdown menu
            this.addFunctionHome.btnAddFolder.Click += BtnAddFolder_Click;
            this.addFunctionHome.btnAddTest.Click += BtnAddTest_Click;

            questions = new List<Question>();
        }


        #region functionBar
        private void BtnQLTK_Click(object sender, EventArgs e)
        {
            dropmenuAdmin.Visible = false;
            OpenChildForm(new Admin(this),panelTongquan);
        }

        #endregion

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            
        }
        #region Thêm Folder mới
        private void BtnAddTest_Click(object sender, EventArgs e)
        {
            NewTest newTest = new NewTest(this);
            addFunctionHome.Visible = false;
            newTest.ShowDialog();
        }

        private void BtnAddFolder_Click(object sender, EventArgs e)
        {
            NewFolder newFolder = new NewFolder();
            addFunctionHome.Visible = false;
            newFolder.ShowDialog();
            subjects = Subject_BUS.Instance.GetSubjects();
            LoadAll();
        }
        #endregion

        #region Click DataGrid
        private void LblfolderName_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            lblFileName.Text = control.Tag.ToString();
            panelButtonDetail.Visible = false;
            picIconDetail.Image = Properties.Resources.Folder;

        }
        private void ListSubject_Click(object sender, EventArgs e)
        {
            ListFolder listFolder = (ListFolder)sender;
            lblFileName.Text = listFolder.FolderName;
            panelButtonDetail.Visible = false;
            picIconDetail.Image = Properties.Resources.Folder;
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
        #endregion
        #region LoadForm
        public void LoadListSubject()
        {
            flowSubject.Controls.Clear();
            foreach (Subject subject in subjects)
            {
                if(subject.SubjectID == "0") { continue; }
                ListFolder listSubject = new ListFolder();
                listSubject.FolderName = subject.SubjectName;
                listSubject.CreatedDay = subject.InitiationDay.ToString("dd/MM/yyyy");
                listSubject.ChangedDay = subject.ChangedDay.ToString("dd/MM/yyyy");
                listSubject.Icon = Properties.Resources.Folder;
               
                //ADD TAG
                listSubject.picIcon.Tag = subject.SubjectName;
                listSubject.lblfolderName.Tag = subject.SubjectName;
                listSubject.lblcreatedDay.Tag = subject.SubjectName;
                listSubject.lblChangedDay.Tag = subject.SubjectName;

                //ADD EVENT
                listSubject.Click += ListSubject_Click;
                listSubject.DoubleClick += ListSubject_DoubleClick;
                listSubject.lblfolderName.DoubleClick += LblfolderName_DoubleClick;
                listSubject.lblChangedDay.DoubleClick += LblfolderName_DoubleClick;
                listSubject.lblcreatedDay.DoubleClick += LblfolderName_DoubleClick;
                listSubject.lblfolderName.Click += LblfolderName_Click;
                listSubject.lblChangedDay.Click += LblfolderName_Click;
                listSubject.lblcreatedDay.Click += LblfolderName_Click;
                listSubject.picIcon.Click += LblfolderName_Click;
                flowSubject.Controls.Add(listSubject);
            }
        }

        private void LblfolderName_DoubleClick(object sender, EventArgs e)
        {
            Control list = (Control)sender;
            OpenChildForm(new FileTest(list.Tag.ToString(),this), panelTongquan);
        }

        private void ListSubject_DoubleClick(object sender, EventArgs e)
        {
            ListFolder list = (ListFolder)sender;
            OpenChildForm(new FileTest(list.FolderName,this), panelTongquan);
        }


        private void LoadListTest()
        {
            flowTest.Controls.Clear();
            foreach (Test test in tests)
            {
                if(test.SubjectID == "0")
                {
                    ListFolder listtest = new ListFolder();
                    listtest.FolderName = test.TestName;
                    listtest.CreatedDay = test.InitiationDate.ToString("dd/MM/yyyy");
                    listtest.ChangedDay = test.ChangedDate.ToString("dd/MM/yyyy");

                    listtest.Click += Listtest_Click;
                    listtest.lblfolderName.Click += LblfolderName_ClickTest;
                    listtest.lblChangedDay.Click += LblfolderName_ClickTest;
                    listtest.lblcreatedDay.Click += LblfolderName_ClickTest;
                    flowTest.Controls.Add(listtest);
                }
                
            }

            
        }

        private void LoadAll()
        {
            LoadListTest();
            Task taskSubject = new Task(LoadListSubject);
            try
            {
                LoadListTest();
                taskSubject.RunSynchronously();
            }
            catch
            {
                MessageBox.Show("Tải dữ liệu thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                taskSubject.Dispose();
            }
        }
        private void btnTongquan_Click(object sender, EventArgs e)
        {
            LoadAll();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Load TongQuan
            subjects = Subject_BUS.Instance.GetSubjects();
            tests = Test_BUS.Instance.GetTestsNotSubjectID();
            LoadAll();

        }
        
        
        #endregion

        #region Mở Form con
        public void OpenChildForm(Form childForm,Panel panel)
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

            
        #region Show/Hide DropDown
 
        private void panellFile_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            this.addFunctionHome.Visible = false;
            this.dropmenuAdmin.Visible = false;

        }
        private void panelTongquan_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            this.addFunctionHome.Visible = false;
            this.dropmenuAdmin.Visible = false;

        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            sortedList.Visible = !sortedList.Visible;
            this.addFunctionHome.Visible = false;

        }
        private void btnMore_Click(object sender, EventArgs e)
        {
            this.addFunctionHome.Visible = !addFunctionHome.Visible;
        }
        private void picUser_Click(object sender, EventArgs e)
        {
            dropmenuAdmin.Visible = !dropmenuAdmin.Visible;
        }
        private void FormMain_Click(object sender, EventArgs e)
        {
            this.dropmenuAdmin.Visible = false;
        }
        #endregion
        #region sortedList
        private void BtnChange_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            subjects = Subject_BUS.Instance.SortedChange();
            flowSubject.Controls.Clear();
            LoadListSubject();
        }

        private void BtnNewest_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            subjects.Clear();
            subjects = Subject_BUS.Instance.SortedNewest();
            LoadListSubject();
        }

        private void BtnOldest_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            subjects = Subject_BUS.Instance.SortedOldest();
            LoadListSubject();
        }

        private void BtnZtoA_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            subjects = Subject_BUS.Instance.SortedZtoA();
            LoadListSubject();
        }
        private void BtnAtoZ_Click(object sender, EventArgs e)
        {
            this.sortedList.Visible = false;
            subjects = Subject_BUS.Instance.SortedAtoZ();
            LoadListSubject();
        }





        #endregion

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            subjects = Subject_BUS.Instance.SearchSubject(txtSearch.Texts);
            LoadListSubject();
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            panelDetail.Visible = false;
            panellFile.Visible = false;
            OpenChildForm(new ListTest(this), panelMain);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xoá bài kiểm tra này đồng nghĩa với xoá các thông tin liên quan bao gồm cả bảng điểm và các lần thi. Bạn có chắc chắn muốn xoá?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Xoá toàn bộ các bài kiểm tra trong thư mục
                List<Test> dropTest = Test_BUS.Instance.GetTests(lblFileName.Text);
                foreach(Test test in dropTest)
                {
                    //Lấy toàn bộ chi tiết bài kiểm tra có trong bài kiểm tra này
                    testDetails = TestDetail_BUS.Instance.GetTestDetails(test.TestID);
                    foreach (TestDetail detail in testDetails)
                    {
                        //Xoá toàn bộ câu trả lời của các câu hỏi
                        Question question = Question_BUS.Instance.GetQuestion(detail.QuestionID);
                        questions.Add(question);
                        Answer_BUS.Instance.DelAnswer(question);
                    }
                    //Xoá toàn bộ chi tiết bài kiểm tra
                    TestDetail_BUS.Instance.DelTestDetail(testDetails);
                    //Xoá toàn bộ câu hỏi trong bài kiểm tra
                    Question_BUS.Instance.DelQuestion(questions);

                    //Xoá thông tin về các lần kiểm tra
                    List<TestTimes> testTimes = TestTimes_BUS.Instance.GetTestTimes(test);
                    foreach (TestTimes testTimes1 in testTimes)
                    {
                        Result_BUS.Instance.DelResult(testTimes1);
                    }
                    TestTimes_BUS.Instance.DelTestTimes(testTimes);
                    //Sau khi thực hiện xoá các thông tin của bài kiểm tra thì xoá bài kiểm tra này
                    Test_BUS.Instance.DelTest(test);
                    tests = Test_BUS.Instance.GetListTest();


                    //Xoá thư mục chứa bài kiểm tra
                    Subject sub = Subject_BUS.Instance.FindByName(lblFileName.Text);
                    Subject_BUS.Instance.DelSub(sub);
                    subjects = Subject_BUS.Instance.GetSubjects();
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load lại datagrid
                    LoadAll();
                }
            }
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {

            AdjustFolder adjust = new AdjustFolder(lblFileName.Text);
            adjust.ShowDialog();
            LoadAll();
        }

        private void button_Advanced2_Click(object sender, EventArgs e)
        {
            var query = from subject in db.Subjects
                        join test in db.Tests on subject.SubjectID equals test.SubjectID
                        join testTimes in db.TestTimes on test.TestID equals testTimes.TestID
                        join result in db.Results on testTimes.TestTimesID equals result.TestTimesID
                        where test.TestName == "Math Test 1"
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

            PrintResult printResult=new PrintResult();
            printResult.SetDataSource(results);

            ReportResult reportResult= new ReportResult();
            reportResult.crystalReportViewer1.ReportSource=printResult;
            reportResult.ShowDialog();
            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình?","Thông báp",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelBar.DoDragDrop(label1.Text, DragDropEffects.Move);
            }
        }

        private void panelBar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void panelBar_DragDrop(object sender, DragEventArgs e)
        {
            panelBar.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}
