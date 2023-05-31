using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DAO;
using TestManagement.DTO;

namespace TestManagement.BUS
{
    class TestDetail_BUS
    {
        private static TestDetail_BUS instance;
        public static TestDetail_BUS Instance
        {

            get { if (instance == null) instance = new TestDetail_BUS(); return instance; }
            set { instance = value; }
        }
        public void AddTestDetail(TestDetail detail)
        {
            TestDetail_DAO.Instance.AddTestDetail(detail);
        }
        public int CountQuesinTest(string testID)
        {
            return TestDetail_DAO.Instance.CountQuesinTest(testID);
        }
        public List<TestDetail> GetTestDetails(string TestID)
        {
            return TestDetail_DAO.Instance.GetTestDetails(TestID);
        }
        public void DelTestDetail(List<TestDetail> delList)
        {
            TestDetail_DAO.Instance.DelTestDetail(delList);
        }

    }
}