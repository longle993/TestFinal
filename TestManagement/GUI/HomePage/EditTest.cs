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
using TestManagement.BUS;
using TestManagement.DTO;

namespace TestManagement.GUI.HomePage
{
    public partial class EditTest : Form
    {
        NewQuestion quesNumber;
        Question currentQues;
        CreateTest create;
        List<Answer> allAnswer;

        public EditTest()
        {
            InitializeComponent();
        }

        public EditTest(NewQuestion quesNumber, CreateTest create)
        {
            InitializeComponent();
            this.quesNumber = quesNumber;
            this.create = create;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Chỉnh sửa nội dung câu hỏi & câu trả lời

            currentQues = Question_BUS.Instance.FindByText(quesNumber.TextQuestion);
            if (currentQues != null)
            {
                allAnswer = Answer_BUS.Instance.GetAnswers(currentQues.QuestionID);
                Question adjustQuest = new Question();
                adjustQuest.QuestionID = currentQues.QuestionID;
                adjustQuest.QuestionText = txtTextQues.Texts;
                adjustQuest.LoiGiai = txtLoigiai.Texts;
                Question_BUS.Instance.UpdateQuestion(adjustQuest);

                allAnswer[0].AnswerText = txtAnswerA.Texts;
                allAnswer[1].AnswerText = txtAnswerB.Texts;
                allAnswer[2].AnswerText = txtAnswerC.Texts;
                allAnswer[3].AnswerText = txtAnswerD.Texts;

                Answer_BUS.Instance.UpdateAnswer(allAnswer);

                foreach (Control control in create.flowQues.Controls)
                {
                    if (control is NewQuestion ques && ques.Quesnumber == lblQues.Text)
                    {
                        ques.TextQuestion = adjustQuest.QuestionText;
                        ques.AnswerA = txtAnswerA.Texts;
                        ques.AnswerB = txtAnswerB.Texts;
                        ques.AnswerC = txtAnswerC.Texts;
                        ques.AnswerD = txtAnswerD.Texts;
                    }
                    
                }

            }
            else
            {
                foreach (Control control in create.flowQues.Controls)
                {
                    if(control is NewQuestion ques && ques.Quesnumber == lblQues.Text)
                    {
                        ques.TextQuestion = txtTextQues.Texts;
                        ques.AnswerA = txtAnswerA.Texts;
                        ques.AnswerB = txtAnswerB.Texts;
                        ques.AnswerC = txtAnswerC.Texts;
                        ques.AnswerD = txtAnswerD.Texts;
                    }
                }
            }
            
            MessageBox.Show("Chỉnh sửa thành công");
            create.panelAnswer.Visible = true;
            create.panelQues.Visible = true;
            this.Close();

        }
        private void LoadQues()
        {
            lblQues.Text = quesNumber.Quesnumber;
            txtTextQues.Texts = quesNumber.TextQuestion;
            txtAnswerA.Texts = quesNumber.AnswerA;
            txtAnswerB.Texts = quesNumber.AnswerB;
            txtAnswerC.Texts = quesNumber.AnswerC;
            txtAnswerD.Texts = quesNumber.AnswerD;
        }

        private void EditTest_Load(object sender, EventArgs e)
        {
            LoadQues();
        }

    }
}
