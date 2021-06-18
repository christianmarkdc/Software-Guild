using SGBank.Models;
using SGBank.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Data
{
    public class FileAccountRepository : IAccountRepository
    {
        private const string _filePath = @".\Accounts.txt";
        string[] rows = File.ReadAllLines(_filePath);
        private Account[] accounts = new Account[3];
        public Account[] ReadingFiles()
        {
            Account[] List = new Account[rows.Length];
            //Reading in Accounts
            using (StreamReader reader = new StreamReader(_filePath))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 1; i < rows.Length; i++)
                    {
                        string[] columns = rows[i].Split(',');

                        Account account = new Account();

                        account.AccountNumber = columns[0];
                        account.Name = columns[1];
                        account.Balance = Convert.ToDecimal(columns[2]);
                        switch (columns[3])
                        {
                            case "F":
                                account.Type = (AccountType)1;
                                break;
                            case "B":
                                account.Type = (AccountType)2;
                                break;
                            case "P":
                                account.Type = (AccountType)3;
                                break;
                        }
                        accounts[i - 1] = account;
                    }
                }
            }
            return accounts;
        }

        public Account LoadAccount(string AccountNumber)
        {
            ReadingFiles();
            if (AccountNumber == "11111")
            {
                return accounts[0];
            }
            else if (AccountNumber == "22222")
            {
                return accounts[1];
            }
            else if (AccountNumber == "33333")
            {
                return accounts[2];
            }
            else
            {
                return null;
            }
        }

        public void SaveAccount(Account account)
        {
            using (StreamWriter wr = new StreamWriter(_filePath))
            {
                wr.WriteLine("AccountNumber,Name,Balance,Type");
                for (int i = 0; i < accounts.Length; i++)
                {
                    string enumLetter = accounts[i].Type.ToString();
                    wr.WriteLine($"{accounts[i].AccountNumber},{accounts[i].Name},{accounts[i].Balance},{enumLetter.Substring(0,1)}");
                }
            }
        }
    }
}

