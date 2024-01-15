using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DAO;
using TestManagement.DTO;

namespace TestManagement.BUS
{
    class Test_BUS
    {
        private static Test_BUS instance;
        public static Test_BUS Instance
        {
            get { if (instance == null) instance = new Test_BUS(); return instance; }
            set { instance = value; }
        }
        public List<Test> GetListTest()
        {
            return Test_DAO.Instance.GetListTest();
        }
        public List<Test> GetTests(string subjectName)
        {
            return Test_DAO.Instance.GetTests(subjectName);
        }
        public List<Test> GetTestsNotSubjectID()
        {
            return Test_DAO.Instance.GetTestsNotSubjectID();
        }
        public Test FindByName(string testName)
        {
            return Test_DAO.Instance.FindByName(testName);
        }
        public Test FindByID(string ID)
        {
            return Test_DAO.Instance.FindByID(ID);
        }
        public int CountTest()
        {
            return Test_DAO.Instance.CountTest();
        }
        public void AddTest(Test test)
        {
            Test_DAO.Instance.AddTest(test);
        }
        public List<Test> SortedAtoZ()
        {
            return Test_DAO.Instance.SortedAtoZ();
        }
        public List<Test> SortedZtoA()
        {
            return Test_DAO.Instance.SortedZtoA();
        }
        public List<Test> SortedOldest()
        {
            return Test_DAO.Instance.SortedOldest();
        }
        public List<Test> SortedNewest()
        {
            return Test_DAO.Instance.SortedNewest();
        }
        public List<Test> SortedChange()
        {
            return Test_DAO.Instance.SortedChange();
        }
        public void DelTest(Test test)
        {
            Test_DAO.Instance.DelTest(test);
        }
        public void UpdateTest(Test test)
        {
            Test_DAO.Instance.UpdateTest(test);
        }
        public void UpdateTestTime(Test test, string time)
        {
            Test_DAO.Instance.UpdateTestTime(test, time);
        }
    }
}