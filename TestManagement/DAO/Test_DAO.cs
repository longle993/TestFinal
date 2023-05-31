using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.DTO;

namespace TestManagement.DAO
{
    class Test_DAO
    {
        ConnectingData db = new ConnectingData();
        private static Test_DAO instance;
        public static Test_DAO Instance
        {
            get { if (instance == null) instance = new Test_DAO(); return instance; }
            set { instance = value; }
        }
        public List<Test> GetListTest()
        {
            return db.Tests.ToList();
        }
        public List<Test> GetTests(string subjectName)
        {
            Subject existSubject = db.Subjects.SingleOrDefault(p => p.SubjectName == subjectName);
            return db.Tests.Where(p => p.SubjectID == existSubject.SubjectID).ToList();
        }

        public Test FindByName(string testName)
        {
            return db.Tests.SingleOrDefault(p => p.TestName == testName);
        }
        public Test FindByID(string ID)
        {
            return db.Tests.SingleOrDefault(p => p.TestID == ID);
        }
        //Lấy thư mục đồng cấp
        public List<Test> GetTestsNotSubjectID()
        {
            return db.Tests.Where(p => p.SubjectID == "").ToList();
        }

        public int CountTest()
        {
            return db.Tests.Count();
        }

        public void AddTest(Test test)
        {
            Test existTest = db.Tests.AsNoTracking().SingleOrDefault(p => p.TestID == test.TestID);
            try
            {
                if (existTest is null)
                {
                    db.Tests.Add(test);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Tên đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Test> SortedAtoZ()
        {
            return db.Tests.OrderBy(p => p.TestName).ToList();
        }
        public List<Test> SortedZtoA()
        {
            return db.Tests.OrderByDescending(p => p.TestName).ToList();
        }
        public List<Test> SortedOldest()
        {
            return db.Tests.OrderBy(p => p.InitiationDate).ToList();
        }
        public List<Test> SortedNewest()
        {
            return db.Tests.OrderByDescending(p => p.InitiationDate).ToList();
        }
        public List<Test> SortedChange()
        {
            return db.Tests.OrderByDescending(p => p.ChangedDate).ToList();
        }

        public void DelTest(Test test)
        {
            db.Tests.Remove(test);
            db.SaveChanges();
        }
    }
}