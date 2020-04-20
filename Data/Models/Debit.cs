using System;
using System.Collections.Generic;

namespace BankingProject.Data.Models
{
    public partial class Debit
    {
        public Debit(int sno, string date, decimal accNo, string name, decimal oldBalance, string mode, decimal debAmount)
        {
            this.Sno = sno;
            this.Date = date;
            this.AccountNo = accNo;
            this.Name = name;
            this.OldBalance = oldBalance;
            this.Mode = mode;
            this.DebAmount = debAmount;
        }
        public Debit()
        {

        }
        public int Sno { get; set; }
        public string Date { get; set; }
        public decimal? AccountNo { get; set; }
        public string Name { get; set; }
        public decimal? OldBalance { get; set; }
        public string Mode { get; set; }
        public decimal? DebAmount { get; set; }
    }
}
