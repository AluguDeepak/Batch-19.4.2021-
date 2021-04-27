using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnBanking_Assessment
{
    abstract class Account
    {
        int accno;
        public Account()
        {
            accno = new Random().Next(100000000, 999999999);
        }
        ~Account() { }
        public int AccountNumber { get { return accno; } }
        public string Username { get; set; }
        public int Balance { get; set; }
        public abstract void OpenAccount(Account account);
        public abstract void CloseAccount(int acno);
        public abstract void EditAccount(int acno,string uname);
        public abstract void Deposit(int acno,int amt);
        public abstract void WithDraw(int acno,int amt);
        public abstract void Checkbalance(int acno);
      
    }
}
