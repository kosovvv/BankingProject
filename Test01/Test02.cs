using BankingProject.Business;
using BankingProject.Data;
using BankingProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.Tests
{
    public class Test02
    {
        [TestCase]
        public void CreateAccount_saves_an_account_via_context()
        {
            string date = DateTime.UtcNow.ToString();

            var mockSet = new Mock<DbSet<UserAccount>>();

            var mockContext = new Mock<banking_dbContext>();
            mockContext.Setup(m => m.UserAccount).Returns(mockSet.Object);

            var service = new UserAccountController(mockContext.Object);
            service.Add(new UserAccount(1, "Georgi Georgiev", "11/06/2000", "0878444484", "bul Bulgaria 4", "Smolyan", "Smolyan", "Male", "married",
                    "Maria", "Yordan", 7500, date.ToString()));

            mockSet.Verify(m => m.Add(It.IsAny<UserAccount>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}