using BankingProject.Data;
using BankingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Business
{
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
        public void Add(Deposit deposit)
        {
            context.Deposit.Add(deposit);
            context.SaveChanges();
        }
        public List<Deposit> GetDepositDetails(decimal accNo)
        {
            var items = (from u in context.Deposit where u.AccountNo == accNo select u);
            return items.ToList();
        }
    }
}