﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DTO;

namespace TestManagement.DAO
{
    class TestTimes_DAO
    {
        ConnectingData db = new ConnectingData();
        private static TestTimes_DAO instance;
        public static TestTimes_DAO Instance
        {
            get { if (instance == null) instance = new TestTimes_DAO();return instance; }
            set { instance = value; }
        }
        public void AddTestTimes(TestTimes testtime)
        {
            db.TestTimes.Add(testtime);
            db.SaveChanges();
        }

        public void DelTestTimes(List<TestTimes> testTimes)
        {
            foreach(TestTimes times in testTimes)
            {
                db.TestTimes.Remove(times);
                db.SaveChanges();
            }
        }
        public List<TestTimes> GetTestTimes(Test test)
        {
            return db.TestTimes.Where(p => p.TestID == test.TestID).ToList();
        }
    }
}