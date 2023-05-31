using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagement.DTO;

namespace TestManagement.DAO
{
    class Account_DAO
    {
        ConnectingData db = new ConnectingData();
        private static Account_DAO instance;
        public static Account_DAO Instance
        {
            get { if (instance == null) instance = new Account_DAO();return instance; }
            set { instance = value; }
        }
        public List<Account> GetAccounts()
        {
            return db.Accounts.ToList();
        }
        public List<Account> FindByUserName(string userName)
        {
            return db.Accounts.Where(p => p.UserName.StartsWith(userName)).ToList();
        }
        public Account CheckAccount(string username, string password)
        {
            return db.Accounts.SingleOrDefault(p => p.UserName == username && p.Password == password);
        }
        public Account CheckEmail(string email)
        {
            return db.Accounts.SingleOrDefault(p => p.Email == email);
        }
        public Account CheckUserName(string userName)
        {
            return db.Accounts.SingleOrDefault(p => p.UserName == userName);
        }
        public void UpdateAccount(string email,string password)
        {
            Account existAccount = db.Accounts.Find(email);
            existAccount.Password = password;
            db.SaveChanges();
        }
        public void AddAccount(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }
    }
}
