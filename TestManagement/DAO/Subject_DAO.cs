
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.DTO;

namespace TestManagement.DAO
{
    class Subject_DAO
    {
        ConnectingData db = new ConnectingData();
        private static Subject_DAO instance;
        public static Subject_DAO Instance
        {
            get { if (instance == null) instance = new Subject_DAO();return instance; }
            set { instance = value; }
        }
        public List<Subject> GetSubjects()
        {
            return db.Subjects.ToList();
        }

        public void AddSubject(Subject sub)
        {
            Subject existSubject = db.Subjects.AsNoTracking().SingleOrDefault(p => p.SubjectName == sub.SubjectName);
            try
            {
                if (existSubject is null)
                {
                    db.Subjects.Add(sub);
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
                MessageBox.Show("Có lỗi xảy ra!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                   
        }
        public int CountSubject()
        {
            return db.Subjects.Count();
        }

        public void DelSub(Subject sub)
        {
            db.Subjects.Remove(sub);
            db.SaveChanges();
        }
        public Subject FindByName(string subName)
        {
            return db.Subjects.SingleOrDefault(p => p.SubjectName == subName);
        }
        public List<Subject> SortedAtoZ()
        {
            return db.Subjects.OrderBy(p => p.SubjectName).ToList();
        }
        public List<Subject> SortedZtoA()
        {
            return db.Subjects.OrderByDescending(p=>p.SubjectName).ToList();
        }
        public List<Subject> SortedOldest()
        {
            return db.Subjects.OrderBy(p => p.InitiationDay).ToList();
        }
        public List<Subject> SortedNewest()
        {
            return db.Subjects.OrderByDescending(p => p.InitiationDay).ToList();
        }
        public List<Subject> SortedChange()
        {
            return db.Subjects.OrderByDescending(p => p.ChangedDay).ToList();
        }
        public List<Subject> SearchSubject(string name)
        {
            return db.Subjects.Where(p=>p.SubjectName.Contains(name)).ToList();
        }
        public void UpdateSubject(string subName,string nameChanged)
        {
            Subject existSub = db.Subjects.SingleOrDefault(p => p.SubjectName == subName);
            try
            {
                if (existSub != null)
                {
                    existSub.SubjectName = nameChanged;
                    existSub.ChangedDay = DateTime.Now;
                    db.SaveChanges();
                }
            }
            
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
