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
using TestManagement.UserControl_Test;

namespace TestManagement.GUI.HomePage
{
    public partial class TryTest : Form
    {
        Test newTest;
        List<TestDetail> TestDetails;
        Question question;
        List<Answer> answers;
        public TryTest()
        {
            InitializeComponent();
        }
        public TryTest(Test newtest)
        {
            InitializeComponent();
            this.newTest = newtest;
        }
        private void TryTest_Load(object sender, EventArgs e)
        {
            LoadListTest(newTest);
        }
        void LoadListTest(Test test)
        {
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
