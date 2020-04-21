using BankingProject.Data;
using BankingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Business
{
    public class DebitController
    {
        private banking_dbContext context;
        public DebitController(banking_dbContext cont)
        {
            this.context = cont;
        }
        public DebitController()
        {
            context = new banking_dbContext();
        }
        public void Add(Debit debit)
        {
            context.Debit.Add(debit);
            context.SaveChanges();
        }
        public List<Debit> GetDebitDetails(decimal accNo)
        {
            var items = (from u in context.Debit where u.AccountNo == accNo select u);
            return items.ToList();
        }
    }
}
