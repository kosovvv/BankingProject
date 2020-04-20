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
    public class Test08
    {
        [TestCase]
        public void AddDebitInDatabase_ShouldReturnDebitDetails()
        {
            DateTime date = DateTime.UtcNow;
            var data = new List<Debit>()
                {
                    new Debit(1,DateTime.UtcNow.ToString(),1,"Georgi Georgiev",7500, "In cheque", 1000),
                    new Debit(2,DateTime.UtcNow.ToString(),2, "Ivan Ivanov", 5000, "Cash", 500)
                }.AsQueryable();
            var mockSet = new Mock<DbSet<Debit>>();
            mockSet.As<IQueryable<Debit>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Debit>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Debit>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Debit>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            var mockContext = new Mock<banking_dbContext>();
            mockContext.Setup(c => c.Debit).Returns(mockSet.Object);

            var service = new DebitController(mockContext.Object);
            data.ToList().ForEach(a => service.Add(a));

            var debit = service.GetDebitDetails(2).First();
            Assert.AreEqual(500, debit.DebAmount);
        }
    }
}
