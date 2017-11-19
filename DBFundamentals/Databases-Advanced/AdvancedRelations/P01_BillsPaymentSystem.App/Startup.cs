using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;
using P01_BillsPaymentSystem.Data.Models.Constants;
using P01_BillsPaymentSystem.Data.Models.Enumerations;

namespace P01_BillsPaymentSystem
{
    public class Startup
    {
        public static void Main()
        {
            var dbContext = new BillsPaymentSystemContext();

            using (dbContext)
            {
                //dbContext.Database.Migrate();
                Seed(dbContext);

                //var userId = int.Parse(Console.ReadLine());
                //var userInfo = GetUserInfo(dbContext, userId);
                //Console.WriteLine(userInfo);

                PayBills(5, 1, dbContext);
                Console.WriteLine();
            }
        }

        private static void PayBills(int userId, decimal amount, BillsPaymentSystemContext context)
        {
            var accountsMethods = context
                .PaymentMethods
                .Include(pm => pm.BankAccount)
                .Where(pm => pm.UserId == userId && pm.Type == PaymentType.BankAccount)
                .OrderBy(pm => pm.BankAccountId)
                .ToArray();

            var cardsMethods = context
                .PaymentMethods
                .Include(pm => pm.CreditCard)
                .Where(pm => pm.UserId == userId && pm.Type == PaymentType.CreditCard)
                .OrderBy(pm => pm.CreditCardId)
                .ToArray();

            var totalMoney = accountsMethods.Sum(pm => pm.BankAccount.Balance) +
                                 cardsMethods.Sum(c => c.CreditCard.LimitLeft);

            if (totalMoney >= amount)
            {
                Withdraw(amount, accountsMethods);
                Withdraw(amount, cardsMethods);

                context.SaveChanges();
                return;
            }

            Console.WriteLine(ErrorMessages.NotEnoughMoney);
        }

        private static void Withdraw(decimal amount, PaymentMethod[] accountsMethods)
        {
            foreach (var account in accountsMethods)
            {
                var moneyToBeTaken = 0.0m;
                if (account.Type.Equals(PaymentType.CreditCard))
                {
                    moneyToBeTaken = Math.Min(amount, account.CreditCard.LimitLeft);
                    account.CreditCard.Withdraw(moneyToBeTaken);
                }
                else
                {
                    moneyToBeTaken = Math.Min(amount, account.BankAccount.Balance);
                    account.BankAccount.Withdraw(moneyToBeTaken);
                }

                amount -= moneyToBeTaken;

                if (amount == 0)
                {
                    break;
                }
            }
        }

        private static string GetUserInfo(BillsPaymentSystemContext dbContext, int userId)
        {
            var sb = new StringBuilder();

            using (dbContext)
            {
                var user = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
                if (user is null)
                {
                    sb.AppendLine($"User with id {userId} not found!");
                    return sb.ToString();
                }

                sb.AppendLine($"User: {user.FirstName} {user.LastName}");

                AddUserPaymentMethodsInfo(sb, dbContext, userId);

            }

            return sb.ToString().Trim();
        }

        private static void AddUserPaymentMethodsInfo(StringBuilder sb, BillsPaymentSystemContext dbContext, int userId)
        {
            var paymentMethods = dbContext
                .PaymentMethods
                .Where(pm => pm.UserId == userId)
                .Include(pm => pm.CreditCard)
                .Include(pm => pm.BankAccount)
                .ToList();

            AddCreditCardsInfo(sb, paymentMethods);
            AddBankAccountInfo(sb, paymentMethods);

        }

        private static void AddCreditCardsInfo(StringBuilder sb, List<PaymentMethod> paymentMethods)
        {
            sb.AppendLine("Credit Cards:");

            foreach (var paymentMethod in paymentMethods.Where(pm => pm.Type == PaymentType.CreditCard))
            {
                sb.AppendLine($"-- ID: {paymentMethod.User.UserId}");
                sb.AppendLine($"--- Limit: {paymentMethod.CreditCard.Limit:f2}");
                sb.AppendLine($"--- Money Owed: {paymentMethod.CreditCard.MoneyOwed:f2}");
                sb.AppendLine($"--- Limit Left:: {paymentMethod.CreditCard.LimitLeft:f2}");
                sb.AppendLine(
                    $"--- Expiration Date: {paymentMethod.CreditCard.ExpirationDate.Year}/{paymentMethod.CreditCard.ExpirationDate.Month}");
            }
        }

        private static void AddBankAccountInfo(StringBuilder sb, List<PaymentMethod> paymentMethods)
        {
            sb.AppendLine("Bank Accounts:");

            foreach (var paymentMethod in paymentMethods.Where(pm => pm.Type == PaymentType.BankAccount))
            {
                sb.AppendLine($"-- ID: {paymentMethod.User.UserId}");
                sb.AppendLine($"--- Balance: {paymentMethod.BankAccount.Balance:f2}");
                sb.AppendLine($"--- Bank: {paymentMethod.BankAccount.BankName}");
                sb.AppendLine($"--- SWIFT: {paymentMethod.BankAccount.SWIFTCode}");
            }
        }

        private static void Seed(BillsPaymentSystemContext dbContext)
        {
            var user = new User("John", "Smith", "smithJs@gmail.com", "somePassword");
            var cards = SeedCreditCards();
            var bankAccount = new BankAccount(1000m, "CoolBank", "SWPP252P");
            var paymentMethods = new PaymentMethod[]
            {
                new PaymentMethod(user,cards[0],PaymentType.CreditCard),

                //======= test index ========// 
                //new PaymentMethod(user,cards[0],PaymentType.CreditCard),

                new PaymentMethod(user,cards[1],PaymentType.CreditCard),

                new PaymentMethod(user,bankAccount,PaymentType.BankAccount),

                //======test check constraint======//
                //new PaymentMethod(user,bankAccount,cards[1],PaymentType.BankAccount)

            };

            dbContext.Users.Add(user);
            dbContext.CreditCards.AddRange(cards);
            dbContext.BankAccounts.Add(bankAccount);
            dbContext.PaymentMethods.AddRange(paymentMethods);

            dbContext.SaveChanges();
        }

        private static CreditCard[] SeedCreditCards()
        {
            var cards = new CreditCard[]
            {
                new CreditCard(100m,50m,new DateTime(1999,02,05)),
                new CreditCard(20000,3000,new DateTime(2012,05,06)),
                new CreditCard(10m,0.5m,new DateTime(2018,02,05)),
                new CreditCard(3500m,500m,new DateTime(2013,06,04)),
                new CreditCard(2900m,2800m,new DateTime(2017,09,01)),
            };

            return cards;
        }
    }
}
