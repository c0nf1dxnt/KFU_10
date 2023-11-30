using System;

namespace BankLibrary
{
    public class BankTransaction
    {
        private readonly DateTime transactionTime;
        private readonly decimal amount;

        public BankTransaction(decimal amount)
        {
            transactionTime = DateTime.Now;
            this.amount = amount;
        }
        public string PrintInfoAboutTransaction()
        {
            return $"Транзакция на сумму {amount}₽ была совершена в {transactionTime}\n";
        }
    }
}