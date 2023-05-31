using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DTO;

namespace TestManagement.DAO
{
    class Result_DAO
    {
        ConnectingData db = new ConnectingData();
        private static Result_DAO instance;
        public static Result_DAO Instance
        {
            get { if (instance == null) instance = new Result_DAO(); return instance; }
            set { instance = value; }
        }
        public void AddResult(Result result)
        {
            db.Results.Add(result);
            db.SaveChanges();
        }

        public void DelResult(TestTimes testTimes)
        {
            List<Result> results = db.Results.Where(p => p.TestTimesID == testTimes.TestTimesID).ToList();
            foreach(Result result in results)
            {
                db.Results.Remove(result);
                db.SaveChanges();
            }
        }  
        public void GetListResult()
        {
            var query = from subject in db.Subjects
                        join test in db.Tests on subject.SubjectID equals test.SubjectID
                        join testTimes in db.TestTimes on test.TestID equals testTimes.TestID
                        join result in db.Results on testTimes.TestTimesID equals result.TestTimesID
                        select new
                        {
                            subject.SubjectName,
                            test.TestName,
                            testTimes.TestDate,
                            result.StudentName,
                            result.MSSV,
                            result.NumberCorrect,
                            result.Score
                        };

            var results = query.ToList();
        }
    }
}
