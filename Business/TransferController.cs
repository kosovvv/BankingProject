using BankingProject.Data;
using BankingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Business
{
    public class TransferController
    {
        private banking_dbContext context;
        public TransferController(banking_dbContext cont)
        {
            this.context = cont;
        }
        public TransferController()
        {
            context = new banking_dbContext();
        }
        public void Add(Transfer transfer)
        {
            context.Transfer.Add(transfer);
            context.SaveChanges();
        }
        public List<Transfer> GetTransferDetails(decimal accNo)
        {
            var items = (from u in context.Transfer where u.AccountNo == accNo select u);
            return items.ToList();
        }
    }
}
