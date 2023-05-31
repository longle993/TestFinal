using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DAO;
using TestManagement.DTO;

namespace TestManagement.BUS
{
    class Question_BUS
    {
        private static Question_BUS instance;
        public static Question_BUS Instance
        {
            get { if (instance == null) instance = new Question_BUS(); return instance; }
            set { instance = value; }
        }
        public int CountQues()
        {
            return Question_DAO.Instance.CountQues();
        }
        public void AddQues(Question ques)
        {
            Question_DAO.Instance.AddQues(ques);
        }
        public Question GetQuestion(string QuestionID)
        {
            return Question_DAO.Instance.GetQuestion(QuestionID);
        }
        public void DelQuestion(List<Question> ques)
        {
            Question_DAO.Instance.DelQuestion(ques);
        }
        public Question FindByText(string text)
        {
            return Question_DAO.Instance.FindByText(text);
        }
        public void UpdateQuestion(Question ques)
        {
            Question_DAO.Instance.UpdateQuestion(ques);
        }
    }
}