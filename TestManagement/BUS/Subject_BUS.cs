using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DAO;
using TestManagement.DTO;

namespace TestManagement.BUS
{
    class Subject_BUS
    {
        private static Subject_BUS instance;
        public static Subject_BUS Instance
        {
            get { if (instance == null) instance = new Subject_BUS(); return instance; }
            set { instance = value; }
        }
        public List<Subject> GetSubjects()
        {
            return Subject_DAO.Instance.GetSubjects();
        }
        public void AddSubject(Subject sub)
        {
            Subject_DAO.Instance.AddSubject(sub);
        }
        public int CountSubject()
        {
            return Subject_DAO.Instance.CountSubject();
        }
        public void DelSub(Subject sub)
        {
            Subject_DAO.Instance.DelSub(sub);
        }
        public Subject FindByName(string subName)
        {
            return Subject_DAO.Instance.FindByName(subName);
        }
        public List<Subject> SortedAtoZ()
        {
            return Subject_DAO.Instance.SortedAtoZ();
        }
        public List<Subject> SortedZtoA()
        {
            return Subject_DAO.Instance.SortedZtoA();
        }
        public List<Subject> SortedOldest()
        {
            return Subject_DAO.Instance.SortedOldest();
        }
        public List<Subject> SortedNewest()
        {
            return Subject_DAO.Instance.SortedNewest();
        }
        public List<Subject> SortedChange()
        {
            return Subject_DAO.Instance.SortedChange();
        }
        public List<Subject> SearchSubject(string name)
        {
            return Subject_DAO.Instance.SearchSubject(name);
        }
        public void UpdateSubject(string subName,string nameChanged)
        {
            Subject_DAO.Instance.UpdateSubject(subName,nameChanged);
        }
    }
}
