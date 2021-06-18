using NUnit.Framework;
using SGBank.BLL.DepositRules;
using SGBank.BLL;
using SGBank.Models;
using SGBank.Models.Interfaces;
using SGBank.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.BLL.WithdrawRules;

namespace SGBank.Tests
{
    [TestFixture]
    public class PremiumAccountTests
    {
        [TestCase("33333", "Premium Account", 1500, AccountType.Basic, -1000, 1500, false)]
        [TestCase("33333", "Premium Account", 100, AccountType.Premium, 100, 100, false)]
        [TestCase("33333", "Premium Account", 100, AccountType.Premium, -700, 100, false)]
        [TestCase("33333", "Premium Account", 150, AccountType.Premium, -50, 100, true)]
        [TestCase("33333", "Premium Account", 100, AccountType.Premium, -250, -150, true)]
        public void BasicAccountWithdrawRuleTest(string accountNumber, string name, decimal balance, AccountType accountType, decimal amount, decimal newBalance, bool expectedResult)
        {
            IWithdraw withdraw = new PremiumAccountWithdrawRule();
            Account account = new Account
            {
                AccountNumber = accountNumber,
                Balance = balance,
                Type = accountType,
                Name = name
            };

            AccountWithdrawResponse response = withdraw.Withdraw(account, amount);
            Assert.AreEqual(expectedResult, response.Success);
        }
    }
}

