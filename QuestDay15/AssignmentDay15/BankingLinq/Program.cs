using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLinq
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

    }

    public class Transaction
    {
        public int Id { get; set; }
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<Account>
            {
                new Account {Id= 1,Name = "Devika",Balance = 10000},
                new Account {Id= 2,Name = "Amritha",Balance = 20000},
                new Account {Id= 3,Name = "John",Balance = 34000},
             };

            var transactions = new List<Transaction>
            {
             new Transaction { Id = 101, FromAccountId = 1, ToAccountId = 2, Amount = 100, DateTime = DateTime.Now },
             new Transaction { Id = 102, FromAccountId = 2, ToAccountId = 3, Amount = 200, DateTime = DateTime.Now },
             new Transaction { Id = 103, FromAccountId = 1, ToAccountId = 3, Amount = 300, DateTime = DateTime.Now }
            };

            var tr = from transaction in transactions
                     join fromAccount in accounts on transaction.FromAccountId equals fromAccount.Id
                     join toAccount in accounts on transaction.ToAccountId equals toAccount.Id
                     select new
                     {
                      TransactionId = transaction.Id,
                      FromAccountName = fromAccount.Name,
                      ToAccountName = toAccount.Name,
                      Amount = transaction.Amount,
                      Date = transaction.DateTime
                     };

            var transactionDetail = transactions
                .Join(
                accounts,
                t => t.FromAccountId,
                a => a.Id,
                (transaction, account) => new { Transaction = transaction, FromAccount = account })
                .Join(
                    accounts,
                    res => res.Transaction.ToAccountId,
                    a => a.Id,
                    (res, toAccount) => new
                    {
                        TransactionId = res.Transaction.Id,
                        FromAccountName = res.FromAccount.Name,
                        ToAccountName = toAccount.Name,
                        Amount = res.Transaction.Amount,
                        Date = res.Transaction.DateTime
                    }
                    );
           foreach(var items in transactionDetail)
            {
                Console.WriteLine($"From: {items.FromAccountName}, To :{items.ToAccountName} Amount : {items.Amount} DateTime : {items.Date}");
            }

            //if (accounts.Any(a => a.Balance == 0))
            //{
            //    Console.WriteLine("No balance");
            //}

            if (accounts.All(a => a.Balance > 0))
            {
                Console.WriteLine("sufficeient balance");
            }

        }
    }
}

