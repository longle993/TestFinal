using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DTO;
using TestManagement.DAO;

namespace TestManagement.BUS
{
    class Account_BUS
    {
        private static Account_BUS instance;
        public static Account_BUS Instance
        {
            get { if (instance == null) instance = new Account_BUS(); return instance; }
            set { instance = value; }
        }
        public List<Account> GetAccounts()
        {
            return Account_DAO.Instance.GetAccounts();
        }
        public List<Account> FindByUserName(string userName)
        {
            return Account_DAO.Instance.FindByUserName(userName);
        }
        public Account CheckAccount(string username, string password)
        {
            return Account_DAO.Instance.CheckAccount(username, password);
        }
        public Account CheckEmail(string email)
        {
            return Account_DAO.Instance.CheckEmail(email);
        }
        public Account CheckUserName(string userName)
        {
            return Account_DAO.Instance.CheckUserName(userName);
        }
        public void UpdateAccount(string email, string password)
        {
            Account_DAO.Instance.UpdateAccount(email, password);
        }
        public void AddAccount(Account account)
        {
            Account_DAO.Instance.AddAccount(account);
        }
    }
}
