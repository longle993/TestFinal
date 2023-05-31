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
using TestManagement.UserControl_Test;
using TestManagement.BUS;
using Org.BouncyCastle.Utilities;


namespace TestManagement.GUI
{
    public partial class CreateTest : Form
    {
        Test newTest;
        List<Question> questions;
        List<TestDetail> details;
        List<Answer> answers;
        private Form currentChildForm;
        public CreateTest()
        {
            InitializeComponent();
        }
        public CreateTest(Test newTest)
        {
            InitializeComponent();
            this.newTest = newTest;
            details = TestDetail_BUS.Instance.GetTestDetails(newTest.TestID);
            questions = new List<Question>();
            
            
        }

        private void GetQues()
        {
            foreach (TestDetail detail in details)
            {
                
                Question ques = Question_BUS.Instance.GetQuestion(detail.QuestionID);
                questions.Add(ques);
            }
        }


        private void LoadExistTest()
        {
            GetQues();
            if(questions.Count == 0 || questions is null) { return; }
            foreach (Question ques in questions)
            {
                NewQuestion newQues = new NewQuestion();
                newQues.txtTextQues.Texts = ques.QuestionText;
                answers = Answer_BUS.Instance.GetAnswers(ques.QuestionID);
                newQues.AnswerA = answers[0].AnswerText;
                newQues.AnswerB = answers[1].AnswerText;
                newQues.AnswerC = answers[2].AnswerText;
                newQues.AnswerD = answers[3].AnswerText;
                int index = flowQues.Controls.Count;
                newQues.QuestionNumber = "Câu " + index.ToString();
                newQues.btnA.Click += BtnA_Click;
                newQues.btnB.Click += BtnB_Click;
                newQues.btnC.Click += BtnC_Click;
                newQues.btnD.Click += BtnD_Click;
                newQues.btnEdit.Click += BtnEdit_Click;
                int buttonIndex = flowQues.Controls.IndexOf((Control)btnAddQues);
                flowQues.Controls.Add(newQues);
                flowQues.Controls.SetChildIndex(newQues, index);
                for (int i = buttonIndex; i < flowQues.Controls.Count - 1; i++)
                {
                    flowQues.Controls.SetChildIndex(flowQues.Controls[i], i + 1);
                }

                //Thêm Question vào thanh bên phải
                txtCountQues.Texts = (flowQues.Controls.Count - 1).ToString();
                QuesSetting setting = new QuesSetting();
                setting.txtMark._TextChanged += TxtMark__TextChanged;
                setting.QuesNumber = newQues.QuestionNumber;

                int indexAns = 1;
                foreach (Answer ans in answers)
                {
                    if(ans.CorrectAnswer == true)
                    {
                        break;
                    }
                    indexAns++;
                }

                switch (indexAns)
                {
                    case 1: setting.TrueAnswer = "A";break;
                    case 2: setting.TrueAnswer = "B";break;
                    case 3: setting.TrueAnswer = "C";break;
                    case 4: setting.TrueAnswer = "D";break;
                }
                flowQuesSetting.Controls.Add(setting);
            }
        }

        private void btnAddQues_Click(object sender, EventArgs e)
        {
            
            //Thêm Question vào thanh bên trái
            NewQuestion ques = new NewQuestion();
            int buttonIndex = flowQues.Controls.IndexOf((Control)sender);
            ques.btnEdit.Click += BtnEdit_Click;
            int index = flowQues.Controls.Count;
            ques.QuestionNumber = "Câu " + index.ToString();
            ques.btnA.Click += BtnA_Click;
            ques.btnB.Click += BtnB_Click;
            ques.btnC.Click += BtnC_Click;
            ques.btnD.Click += BtnD_Click;
            flowQues.Controls.Add(ques);
            flowQues.Controls.SetChildIndex(ques, index);
            for (int i = buttonIndex; i < flowQues.Controls.Count - 1; i++)
            {
                flowQues.Controls.SetChildIndex(flowQues.Controls[i], i + 1);
            }

            //Thêm Question vào thanh bên phải
            txtCountQues.Texts = (flowQues.Controls.Count - 1).ToString();
            QuesSetting setting = new QuesSetting();
            setting.QuesNumber = ques.QuestionNumber;
            setting.txtMark._TextChanged += TxtMark__TextChanged;
            flowQuesSetting.Controls.Add(setting);
        }

        private void TxtMark__TextChanged(object sender, EventArgs e)
        {
            decimal totalMark = 0;
            foreach(Control ctr in flowQuesSetting.Controls)
            {
                if(ctr is QuesSetting setting && setting.txtMark.Texts != "")
                {
                    totalMark += Convert.ToDecimal(setting.txtMark.Texts);
                }
                else if(ctr is QuesSetting set)
                {
                    totalMark +=0;
                }
            }
            txtMark.Texts = totalMark.ToString();
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            SetTrueAnswer(sender, "D");
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            SetTrueAnswer(sender, "C");
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            SetTrueAnswer(sender, "B");

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            SetTrueAnswer(sender, "A");
        }
        
        private void SetTrueAnswer(object sender,string trueAnswer)
        {
            Control control = (Control)sender;
            foreach (QuesSetting ctr in flowQuesSetting.Controls)
            {
                if (ctr.QuesNumber == control.Tag.ToString())
                {
                    ctr.TrueAnswer = trueAnswer;
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            foreach (Control ctr in flowQues.Controls)
            {
                if (ctr is NewQuestion ques && ques.Quesnumber == control.Tag.ToString())
                {
                    panelQues.Visible = false;
                    panelAnswer.Visible = false;
                    OpenChildForm(new EditTest(ques,this));
                    break;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateTest_Load(object sender, EventArgs e)
        {
            lblTestName.Text = newTest.TestName;
            LoadExistTest();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Test existTest = Test_BUS.Instance.FindByName(lblTestName.Text);
            if (existTest == null)
            {
                Test_BUS.Instance.AddTest(newTest);

            }

            //Xóa các câu hỏi cũ
            List<TestDetail> delList = TestDetail_BUS.Instance.GetTestDetails(newTest.TestID);
            if(delList != null)
            {
                foreach (TestDetail detail in delList)
                {
                    Question ques = Question_BUS.Instance.GetQuestion(detail.QuestionID);
                    Answer_BUS.Instance.DelAnswer(ques);
                }
                TestDetail_BUS.Instance.DelTestDetail(delList);
            }
            
            foreach (Control control in flowQues.Controls)
            {
                if (control is NewQuestion ques)
                {
                    //Thêm Question
                    Question question = new Question();
                    string quesID = "Q" + (Question_BUS.Instance.CountQues() + 1).ToString("000");
                    question.QuestionID = quesID;
                    question.QuestionText = ques.txtTextQues.Texts;
                    Question_BUS.Instance.AddQues(question);


                    //Thêm Answer
                    int count = 0;
                    foreach (Control ctr in ques.Controls)
                    {
                        if (ctr is TextBox_Advanced text)
                        {
                            if (count > 0)
                            {
                                Answer ans = new Answer();
                                string ansID = "A" + (Answer_BUS.Instance.CountAns() + 1).ToString("000");
                                ans.AnswerID = ansID;
                                ans.AnswerText = text.Texts;
                                if (text.BackColor == Color.FromArgb(231, 243, 255))
                                {
                                    ans.CorrectAnswer = true;
                                }
                                else
                                {
                                    ans.CorrectAnswer = false;
                                }
                                ans.QuestionID = quesID;
                                Answer_BUS.Instance.AddAnswer(ans);
                            }
                            count++;
                        }

                    }

                    //Thêm chi tiết bài kiểm tra
                    TestDetail detail = new TestDetail();
                    detail.TestID = newTest.TestID;
                    detail.QuestionID = quesID;
                    foreach (QuesSetting setting in flowQuesSetting.Controls)
                    {
                        if (setting.QuesNumber == ques.Quesnumber)
                        {
                            detail.QuestionPoint = Convert.ToDecimal(setting.Mark);
                        }
                    }
                    TestDetail_BUS.Instance.AddTestDetail(detail);
                }

            }

        }
    }
}
