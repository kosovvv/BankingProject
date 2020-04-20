using System;
using System.Collections.Generic;

namespace BankingProject.Data.Models
{
    public partial class Deposit
    {
        public Deposit(int sno, decimal accNo, string name, decimal oldbalance,string mode, decimal dipAmount, string date)
        {
            this.Sno = sno;
            this.AccountNo = accNo;
            this.Name = name;
            this.OldBalance = oldbalance;
            this.Mode = mode;
            this.DipAmount = dipAmount;
            this.Date = date;
        }
        public Deposit()
        {

        }
        public int Sno { get; set; }
        public decimal? AccountNo { get; set; }
        public string Name { get; set; }
        public decimal? OldBalance { get; set; }
        public string Mode { get; set; }
        public decimal? DipAmount { get; set; }
        public string Date { get; set; }
    }
}
