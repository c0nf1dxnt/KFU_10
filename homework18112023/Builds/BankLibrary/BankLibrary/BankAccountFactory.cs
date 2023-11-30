using System;
using System.Collections;

namespace BankLibrary
{
    public class BankAccountFactory
    {
        static private Hashtable accounts = new Hashtable();
        public int CreateAccount()
        {
            BankAccount account = new BankAccount();
            accounts.Add(account.GetAccountNumber(), account);
            return account.GetAccountNumber();
        }
        public int CreateAccount(BankAccount.AccountType accountType)
        {
            BankAccount account = new BankAccount(accountType);
            accounts.Add(account.GetAccountNumber(), account);
            return account.GetAccountNumber();
        }
        public int CreateAccount(decimal accountBalance)
        {
            BankAccount account = new BankAccount(accountBalance);
            accounts.Add(account.GetAccountNumber(), account);
            return account.GetAccountNumber();
        }
        public int CreateAccount(decimal accountBalance, BankAccount.AccountType accountType)
        {
            BankAccount account = new BankAccount(accountBalance, accountType);
            accounts.Add(account.GetAccountNumber(), account);
            return account.GetAccountNumber();
        }
        public void DeleteAccount(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts.Remove(accountNumber);
                Console.WriteLine($"Банковский счёт с номером {accountNumber} успешно закрыт!");
            }
            else
            {
                Console.WriteLine($"Банковский счёт с номером {accountNumber} не существует!");
            }
        }
    }
}
