using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DTO;

namespace TestManagement.DAO
{
    class TestDetail_DAO
    {
        ConnectingData db = new ConnectingData();
        private static TestDetail_DAO instance;
        public static TestDetail_DAO Instance
        {
            get { if (instance == null) instance = new TestDetail_DAO(); return instance; }
            set { instance = value; }
        }
        public int CountQuesinTest(string testID)
        {
            List<TestDetail> detail = db.TestDetails.Where(p => p.TestID == testID).ToList();
            return detail.Count;
        }
        public void AddTestDetail(TestDetail detail)
        {
            db.TestDetails.Add(detail);
            db.SaveChanges();
        }
        public List<TestDetail> GetTestDetails(string TestID)
        {
            return db.TestDetails.Where(p => p.TestID==TestID).ToList();
        }
        public void DelTestDetail(List<TestDetail> delList)
        {
            foreach (TestDetail detail in delList)
            {
                db.TestDetails.Remove(detail);
                db.SaveChanges();
            }
        }
        public TestDetail GetTestDetail(string QuestionID)
        {
            return db.TestDetails.SingleOrDefault(p => p.QuestionID==QuestionID);
        }
    }
}