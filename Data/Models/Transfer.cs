using System;
using System.Collections.Generic;

namespace BankingProject.Data.Models
{
    public partial class Transfer
    {
        public Transfer(int sno, string date, decimal accNo, string name, decimal balance, decimal toTransfer)
        {
            this.Sno = sno;
            this.Date = date;
            this.AccountNo = accNo;
            this.Name = name;
            this.Balance = balance;
            this.ToTransfer = ToTransfer;
        }
        public Transfer()
        {

        }
        public int Sno { get; set; }
        public string Date { get; set; }
        public decimal? AccountNo { get; set; }
        public string Name { get; set; }
        public decimal? Balance { get; set; }
        public decimal? ToTransfer { get; set; }
    }
}
