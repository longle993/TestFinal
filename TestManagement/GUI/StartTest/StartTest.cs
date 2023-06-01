using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using TestManagement.BUS;
using TestManagement.DTO;
using TestManagement.UserControl_Test;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Control = System.Windows.Forms.Control;

namespace TestManagement.GUI.HomePage
{
    public partial class StartTest : Form
    {
        Test newTest;
        List<TestDetail> TestDetails;
        Question question;
        List<Answer> answers;
        Timer timer;
        TimeSpan TestTime;
        int NumberCorrect;
        decimal Score;
        TestTimes testTimes;

        string name;
        string mssv;
        public StartTest()
        {
            InitializeComponent();
        }
        public StartTest(Test newtest, string name, string mssv, TestTimes testTimes)
        {
            InitializeComponent();
            this.newTest = newtest;
            this.name = name;
            this.mssv = mssv;
            this.testTimes = testTimes;
        }
        private void StartTest_Load(object sender, EventArgs e)
        {
            lblMSSV.Text = mssv;
            lblName.Text = name;
            LoadListTest(newTest);
        }
        void LoadListTest(Test test)
        {
            SetTime(test);
            TestDetails = TestDetail_BUS.Instance.GetTestDetails(test.TestID);
            int count = 1;
            foreach (TestDetail testDetail in TestDetails)
            {
                TestQuestion testQuestion = new TestQuestion();
                question = Question_BUS.Instance.GetQuestion(testDetail.QuestionID);
                answers = Answer_BUS.Instance.GetAnswers(testDetail.QuestionID);
                testQuestion.lblTextQues.Text = question.QuestionText;
                testQuestion.lblAnswerA.Text = answers[0].AnswerText;
                testQuestion.lblAnswerB.Text = answers[1].AnswerText;
                testQuestion.lblAnswerC.Text = answers[2].AnswerText;
                testQuestion.lblAnswerD.Text = answers[3].AnswerText;

                testQuestion.btnA.Click += Btn_Click;
                testQuestion.btnB.Click += Btn_Click;
                testQuestion.btnC.Click += Btn_Click;
                testQuestion.btnD.Click += Btn_Click;

                testQuestion.btnA.Tag = count;
                testQuestion.btnB.Tag = count;
                testQuestion.btnC.Tag = count;
                testQuestion.btnD.Tag = count;
                // Đánh dấu để kiểm đáp án ở dưới
                testQuestion.panelbtnA.Tag = answers[0].AnswerText;
                testQuestion.panelbtnB.Tag = answers[1].AnswerText;
                testQuestion.panelbtnC.Tag = answers[2].AnswerText;
                testQuestion.panelbtnD.Tag = answers[3].AnswerText;

                testQuestion.lblQuesNumber.Text=count.ToString();
                this.flowQues.Controls.Add(testQuestion);
                CreateButton(count, testQuestion);
                count++;
            }
        }
        // Đánh dấu câu hỏi đã làm 
        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (Button btn in flowQuesNumber.Controls)
            {
                if (button.Tag.ToString() == btn.Text)
                {
                    btn.BackColor = Color.FromArgb(199, 224, 247);
                }
            }
        }
        // Tạo button ở bên phải
        void CreateButton(int count, TestQuestion testQuestion)
        {
            Button_Advanced btnQuesNumber = new Button_Advanced();
            btnQuesNumber.BackColor = System.Drawing.Color.White;
            btnQuesNumber.BackgroundColor = System.Drawing.Color.White;
            btnQuesNumber.BorderColor = System.Drawing.Color.Gainsboro;
            btnQuesNumber.BorderRadius = 5;
            btnQuesNumber.BorderSize = 1;
            btnQuesNumber.FlatAppearance.BorderSize = 0;
            btnQuesNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuesNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnQuesNumber.ForeColor = System.Drawing.Color.Black;
            btnQuesNumber.Location = new System.Drawing.Point(3, 3);
            btnQuesNumber.Name = "btnQuesNumber";
            btnQuesNumber.Size = new System.Drawing.Size(65, 56);
            btnQuesNumber.TabIndex = 0;
            btnQuesNumber.Text = count.ToString();
            btnQuesNumber.TextColor = System.Drawing.Color.Black;
            btnQuesNumber.UseVisualStyleBackColor = false;
            btnQuesNumber.Click+=BtnQuesNumber_Click;
            btnQuesNumber.Tag=testQuestion;
            this.flowQuesNumber.Controls.Add(btnQuesNumber);
        }

        private void BtnQuesNumber_Click(object sender, EventArgs e)
        {
            flowQues.ScrollControlIntoView((sender as Button).Tag as TestQuestion);
        }

        // Set thời gian 
        void SetTime(Test test)
        {
            TestTime = test.TestTime;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (TestTime > TimeSpan.Zero)
            {
                TestTime = TestTime.Subtract(TimeSpan.FromSeconds(1));
                lblTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", TestTime.Hours, TestTime.Minutes, TestTime.Seconds);
            }
            else
            {
                btnSubmit_Click(sender,e);
            }
        }
        // Kiểm tra số câu đúng
        void CheckNumberCorrect()
        {
            foreach (Control control in flowQues.Controls)
            {
                if (control is TestQuestion ques)
                {
                    foreach (Control ctr in ques.Controls)
                    {
                        if (ctr is Panel_Advanced panel)
                        {
                            if (panel.BackColor == Color.FromArgb(199, 224, 247))
                            {
                                foreach (Answer ans in answers)
                                {
                                    if (ans.CorrectAnswer == true && panel.Tag.ToString() == ans.AnswerText)
                                    {
                                        Score+=TestDetail_BUS.Instance.GetTestDetail(ans.QuestionID).QuestionPoint;
                                        NumberCorrect++;
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timer.Stop();
            CheckNumberCorrect();
            Result result = new Result();
            result.ResultID = mssv;
            result.TestTimesID = testTimes.TestTimesID;
            result.StudentName = name;
            result.MSSV = lblMSSV.Text;
            result.NumberCorrect = NumberCorrect;
            result.FinishTime=newTest.TestTime.Subtract(TestTime);
            result.Score = Score;            
            if (sender is Button)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn nộp bài không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    Result_BUS.Instance.AddResult(result);
                    this.Close();
                }
            }
            else
            {
                Result_BUS.Instance.AddResult(result);
                MessageBox.Show("Đã hết thời gian làm bài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);              
                this.Close();                
            }
        }
    }
}
