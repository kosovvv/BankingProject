using System;
using System.Collections.Generic;

namespace BankingProject.Data.Models
{
    public partial class UserAccount
    {
        public UserAccount()
        {

        }
        public UserAccount(decimal accNo, string name, string dob, string phoneNo,
            string address, string oblast, string state, string gender, string mstatus,
            string mothername, string fathername, decimal balance, string date)
        {
            this.AccountNo = accNo;
            this.Name = name;
            this.Dob = dob;
            this.PhoneNo = phoneNo;
            this.Address = address;
            this.Oblast = oblast;
            this.State = state;
            this.Gender = gender;
            this.MaritialStatus = mstatus;
            this.MotherName = mothername;
            this.FatherName = fathername;
            this.Balance = balance;
            this.Date = date;
        }
        public decimal AccountNo { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Oblast { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public string MaritialStatus { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public decimal? Balance { get; set; }
        public string Date { get; set; }
    }
}
