using SGBank.BLL;
using SGBank.Models.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGBank.UI.Workflows
{
    public class WithdrawWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            AccountManager accountManager = AccountManagerFactory.Create();

            Console.WriteLine("Enter an account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter a withdraw amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            AccountWithdrawResponse response = accountManager.Withdraw(accountNumber, amount);

            if (response.Success)
            {
                Console.WriteLine("Withdraw completed!");
                Console.WriteLine($"Account Number:{response.Account.AccountNumber}");
                Console.WriteLine($"Old Balance:{response.OldBalance:c}");
                Console.WriteLine($"Amount Withdrew:{response.Amount:c}");
                Console.WriteLine($"New Balance:{response.Account.Balance:c2}");
            }
            else
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(response.Message);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
