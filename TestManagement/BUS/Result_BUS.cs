using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DAO;
using TestManagement.DTO;

namespace TestManagement.BUS
{
    class Result_BUS
    {
        private static Result_BUS instance;
        public static Result_BUS Instance
        {
            get { if (instance == null) instance = new Result_BUS(); return instance; }
            set { instance = value; }
        }
        public void AddResult(Result result)
        {
            Result_DAO.Instance.AddResult(result);
        }
        public void DelResult(TestTimes testTimes)
        {
            Result_DAO.Instance.DelResult(testTimes);
        }
    }
}
