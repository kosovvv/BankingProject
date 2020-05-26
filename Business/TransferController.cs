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
   The TransferController class
   Contains all methods for performing with transfer
   */
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
        //Adds transfer to database and saves via context
        public void Add(Transfer transfer)
        {
            context.Transfer.Add(transfer);
            context.SaveChanges();
        }
        //Retrieve the transfer details by Account Number
        public List<Transfer> GetTransferDetails(decimal accNo)
        {
            var items = (from u in context.Transfer where u.AccountNo == accNo select u);
            return items.ToList();
        }
    }
}
