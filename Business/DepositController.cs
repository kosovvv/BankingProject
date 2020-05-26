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
   The DepositController class
   Contains all methods for performing with deposit
   */
    public class DepositController
    {
        private banking_dbContext context;
        public DepositController(banking_dbContext cont)
        {
            this.context = cont;
        }
        public DepositController()
        {
            context = new banking_dbContext();
        }
        //Adds deposit to database and saves via context
        public void Add(Deposit deposit)
        {
            context.Deposit.Add(deposit);
            context.SaveChanges();
        }
        //Retrieve the debit details by Account Number
        public List<Deposit> GetDepositDetails(decimal accNo)
        {
            var items = (from u in context.Deposit where u.AccountNo == accNo select u);
            return items.ToList();
        }
    }
}