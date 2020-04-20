using BankingProject.Business;
using BankingProject.Data;
using BankingProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingProject.Tests
{
    public class Test06
    {
        [TestCase]
        public void AddDepositInDatabase_ShouldReturnDepositDetails()
        {
            DateTime date = DateTime.UtcNow;
            var data = new List<Deposit>()
                {
                    new Deposit(1,1,"Georgi Georgiev",7500, "In cheque", 1000, DateTime.UtcNow.ToString()),
                    new Deposit(2,2, "Ivan Ivanov", 5000, "Cash", 500, DateTime.UtcNow.ToString())
                }.AsQueryable();
            var mockSet = new Mock<DbSet<Deposit>>();
            mockSet.As<IQueryable<Deposit>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Deposit>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Deposit>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Deposit>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            var mockContext = new Mock<banking_dbContext>();
            mockContext.Setup(c => c.Deposit).Returns(mockSet.Object);

            var service = new DepositController(mockContext.Object);
            data.ToList().ForEach(a => service.Add(a));

            var deposit = service.GetDepositDetails(1).First();
            Assert.AreEqual(1000, deposit.DipAmount);
        }
    }
}
