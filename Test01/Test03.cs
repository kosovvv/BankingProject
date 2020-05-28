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
    public class Test03
    {
        [TestCase]
        public void GetAllAccounts_ShouldReturnAllAccountsInDatabase()
        {
            DateTime date = DateTime.UtcNow;
            var data = new List<UserAccount>()
                {
                    new UserAccount(1, "Georgi Georgiev", "11/06/2000", "0878444484", "bul Bulgaria 4", "Smolyan", "Smolyan", "Male", "married",
                    null, null, 7500, date.ToString()),
                    new UserAccount(2, "Ivan Ivanov", "22/11/2001", "0878171711", "bul Bulgaria 3", "Smolyan", "Smolyan", "Male", "married",
                    null, null, 5000, date.ToString())
                }.AsQueryable();
            var mockSet = new Mock<DbSet<UserAccount>>();
            mockSet.As<IQueryable<UserAccount>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<UserAccount>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<UserAccount>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<UserAccount>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            var mockContext = new Mock<banking_dbContext>();
            mockContext.Setup(c => c.UserAccount).Returns(mockSet.Object);

            var service = new UserAccountController(mockContext.Object);
            data.ToList().ForEach(a => service.Add(a));
            var exceptedCount = 2; 
            var result = service.GetAllAccounts();
            var actualCount = result.Count();
            Assert.AreEqual(exceptedCount, actualCount);
            Assert.AreEqual("Georgi Georgiev", result[0].Name);
        }
    }
}