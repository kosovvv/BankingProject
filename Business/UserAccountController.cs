using BankingProject.Data;
using BankingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Business
{
    /*
    The UserAccountController class
    Contains all methods for performing with useraccount
    */
    public class UserAccountController
    {
        private banking_dbContext context;
        public UserAccountController(banking_dbContext cont)
        {
            this.context = cont;
        }
        public UserAccountController()
        {
            context = new banking_dbContext();
        }
        //Retrieve all accounts from the database
        public List<UserAccount> GetAllAccounts()
        {
            return context.UserAccount.ToList();
        }
        //Adds UserAccount to database and saves via context
        public void Add(UserAccount userAccount)
        {
            context.UserAccount.Add(userAccount);
            context.SaveChanges();
        }
        //Updates existing UserAccount with the data from specified UserAccount
        public void Update(UserAccount userAccount)
        {
            var item = this.Get(userAccount.AccountNo).FirstOrDefault();
            context.Entry(item).CurrentValues.SetValues(userAccount);
            this.context.SaveChanges();
        }
        //Deletes a UserAccount by AccountNumber from database and saves via context
        public void Delete(decimal accNo)
        {
            UserAccount acc = context.UserAccount.First(s => s.AccountNo.Equals(accNo));
            if (acc != null)
            {
                context.UserAccount.Remove(acc);
                context.SaveChanges();
            }
        }
        //Retrieve UserAccount by Account Number
        public List<UserAccount> Get(decimal accNo)
        {
            var items = context.UserAccount.Where(a => a.AccountNo == accNo);
            return items.ToList();
        }
        //Retrieve UserAccount by Account Name
        public List<UserAccount> Get(string name)
        {
            var items = context.UserAccount.Where(a => a.Name == name);
            return items.ToList();
        }
        //Makes transaction operation between two accounts. Takes money from one's account and transfers it to the other
        public void MakeTransaction(decimal totalbal, UserAccount accSend, UserAccount accRecieve)
        {
            accRecieve.Balance = accRecieve.Balance + totalbal;
            accSend.Balance = accSend.Balance - totalbal;
            context.SaveChanges();
        }
        //Makes debit transaction operation. Take money from the specified UserAccount (item)
        public void MakeDebitTransaction(decimal? debitAmount,UserAccount item)
        {
            item.Balance -= Convert.ToDecimal(debitAmount);
            context.SaveChanges();
        }
        //Makes deposit transaction operation. Give money to the specified UserAccount (item)
        public void MakeDepositTransaction(decimal? debitAmount, UserAccount item)
        {
            item.Balance += Convert.ToDecimal(debitAmount);
            context.SaveChanges();
        }
    }
}