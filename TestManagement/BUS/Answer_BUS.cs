using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DTO;
using TestManagement.DAO;

namespace TestManagement.BUS
{
    class Answer_BUS
    {
        private static Answer_BUS instance;
        public static Answer_BUS Instance
        {
            get { if (instance == null) instance = new Answer_BUS(); return instance; }
            set { instance = value; }
        }
        public int CountAns()
        {
            return Answer_DAO.Instance.CountAns();
        }
        public void AddAnswer(Answer ans)
        {
            Answer_DAO.Instance.AddAnswer(ans);
        }
        public List<Answer> GetAnswers(string QuestionID)
        {
            return Answer_DAO.Instance.GetAnswers(QuestionID);
        }
        public void DelAnswer(Question ques)
        {
            Answer_DAO.Instance.DelAnswer(ques);
        }
        public void UpdateAnswer(List<Answer> ans)
        {
            Answer_DAO.Instance.UpdateAnswer(ans);
        }
    }
}