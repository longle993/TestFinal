﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DAO;
using TestManagement.DTO;

namespace TestManagement.BUS
{
    class TestTimes_BUS
    {
        private static TestTimes_BUS instance;
        public static TestTimes_BUS Instance
        {
            get { if (instance == null) instance = new TestTimes_BUS(); return instance; }
            set { instance = value; }
        }
        public void AddTestTimes(TestTimes testtime)
        {
            TestTimes_DAO.Instance.AddTestTimes(testtime);
        }
        public void DelTestTimes(List<TestTimes> testTimes)
        {
            TestTimes_DAO.Instance.DelTestTimes(testTimes);
        }
        public void DeleteTestTime(TestTimes testTimes)
        {
            TestTimes_DAO.Instance.DeleteTestTime(testTimes);
        }
        public List<TestTimes> GetTestTimes(Test test)
        {
            return TestTimes_DAO.Instance.GetTestTimes(test);
        }
        public TestTimes GetTestTime(string code)
        {
            return TestTimes_DAO.Instance.GetTestTime(code);
        }
        public TestTimes GetTestTimeByName(string name)
        {
            return TestTimes_DAO.Instance.GetTestTimeByName(name);
        }
    }
}
