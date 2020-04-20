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
    public class Test07
    {
        [TestCase]
        public void AddTransferInDatabase_ShouldReturnTransferDetails()
        {
            DateTime date = DateTime.UtcNow;
            var data = new List<Transfer>()
                {
                    new Transfer(1, DateTime.UtcNow.ToString(), 1, "Georgi Georgiev", 1000, 2),
                    new Transfer(2, DateTime.UtcNow.ToString(), 2, "Ivan Ivanov", 100, 1)
                }.AsQueryable();
            var mockSet = new Mock<DbSet<Transfer>>();
            mockSet.As<IQueryable<Transfer>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Transfer>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Transfer>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Transfer>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            var mockContext = new Mock<banking_dbContext>();
            mockContext.Setup(c => c.Transfer).Returns(mockSet.Object);

            var service = new TransferController(mockContext.Object);
            data.ToList().ForEach(a => service.Add(a));

            var transfer = service.GetTransferDetails(2).First();
            Assert.AreEqual(100, transfer.Balance);
        }
    }
}
