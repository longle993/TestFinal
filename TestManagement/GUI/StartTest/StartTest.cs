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
using TestManagement.UserControl_Test;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
        TestTimes testTimes = new TestTimes();
        Result result = new Result();
        public StartTest()
        {
            InitializeComponent();
        }
        public StartTest(Test newtest)
        {
            InitializeComponent();
            this.newTest = newtest;
        }
        private void StartTest_Load(object sender, EventArgs e)
        {
            //newTest = Test_BUS.Instance.GetListTest()[1];
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

                this.flowQues.Controls.Add(testQuestion);
                CreateButton(count);
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
        void CreateButton(int count)
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
            this.flowQuesNumber.Controls.Add(btnQuesNumber);
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
            TestTime = TestTime.Subtract(TimeSpan.FromSeconds(1));
            lblTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", TestTime.Hours, TestTime.Minutes, TestTime.Seconds);
            if (TestTime.TotalSeconds <= 0)
            {
                timer.Stop();
                MessageBox.Show("Hết thời gian làm bài!");
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
            testTimes.TestName = "Test 15p";
            testTimes.CodeTest = "123";
            testTimes.TestID = newTest.TestID;
            testTimes.TestDate = DateTime.Now;

            result.ResultID = "3";
            result.TestTimesID = testTimes.TestTimesID;
            result.StudentName = "Tran Van Tuan";
            result.MSSV = lblTextID.Text;
            result.NumberCorrect = NumberCorrect;
            //   result.FinishTime=newTest.TestTime.Subtract(TestTime);
            result.Score = 0;
        }

        /*private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StartTest
            // 
            this.ClientSize = new System.Drawing.Size(953, 607);
            this.Name = "StartTest";
            this.ResumeLayout(false);

        }*/
    }
}