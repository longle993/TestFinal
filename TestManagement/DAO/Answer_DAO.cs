using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.DTO;

namespace TestManagement.DAO
{
    class Answer_DAO
    {
        ConnectingData db = new ConnectingData();
        private static Answer_DAO instance;
        public static Answer_DAO Instance
        {
            get { if (instance == null) instance = new Answer_DAO(); return instance; }
            set { instance = value; }
        }
        public int CountAns()
        {
            return db.Answers.Count();
        }
        public void AddAnswer(Answer ans)
        {
            db.Answers.Add(ans);
            db.SaveChanges();
        }
        public List<Answer> GetAnswers(string QuestionID)
        {
            return db.Answers.Where(p => p.QuestionID==QuestionID).ToList();
        }
        public void DelAnswer(Question ques)
        {
            List<Answer> delList = db.Answers.Where(p => p.QuestionID == ques.QuestionID).ToList();
            db.Answers.Remove(delList[0]);
            db.Answers.Remove(delList[1]);
            db.Answers.Remove(delList[2]);
            db.Answers.Remove(delList[3]);
            db.SaveChanges();
        }
        public void UpdateAnswer(List<Answer> ans)
        {
            try
            {
                foreach (Answer answer in ans)
                {
                    Answer existAns = db.Answers.SingleOrDefault(p => p.AnswerID == answer.AnswerID);
                    if (existAns != null)
                    {
                        existAns.AnswerText = answer.AnswerText;
                        existAns.CorrectAnswer = answer.CorrectAnswer;
                        db.SaveChanges();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}