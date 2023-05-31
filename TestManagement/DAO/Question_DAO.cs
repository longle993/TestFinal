using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.DTO;

namespace TestManagement.DAO
{
    class Question_DAO
    {
        ConnectingData db = new ConnectingData();
        private static Question_DAO instance;
        public static Question_DAO Instance
        {
            get { if (instance == null) instance = new Question_DAO(); return instance; }
            set { instance = value; }
        }
        public int CountQues()
        {
            return db.Questions.Count();
        }
        public void AddQues(Question ques)
        {
            db.Questions.Add(ques);
            db.SaveChanges();
        }
        public Question GetQuestion(string QuestionID)
        {
            return db.Questions.SingleOrDefault(p => p.QuestionID==QuestionID);
        }
        public void DelQuestion(List<Question> ques)
        {
            foreach(Question question in ques)
            {
                db.Questions.Remove(question);
                db.SaveChanges();
            }
            db.SaveChanges();
        }
        public void UpdateQuestion(Question ques)
        {
            Question existQues = db.Questions.SingleOrDefault(p => p.QuestionID == ques.QuestionID);
            try
            {
                if (existQues != null)
                {
                    existQues.QuestionText = ques.QuestionText;
                    existQues.LoiGiai = ques.LoiGiai;
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public Question FindByText(string text)
        {
            return db.Questions.SingleOrDefault(p => p.QuestionText == text);
        }
        
    }
}