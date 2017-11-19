using System;
using P01_BillsPaymentSystem.Data.Models.Constants;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class BankAccount
    {
        private decimal balance;
        private string bankName;
        private string swiftCode;

        public BankAccount(decimal balance, string bankName, string swiftCode)
        {
            this.Balance = balance;
            this.BankName = bankName;
            this.SWIFTCode = swiftCode;
        }

        public BankAccount()
        {
            
        }

        public int BankAccountId { get;  set; }

        public decimal Balance
        {
            get => this.balance;
            private set => this.balance = value;
        }

        public string BankName
        {
            get => this.bankName;
            private set => this.bankName = value;
        }

        public string SWIFTCode
        {
            get => this.swiftCode;
            private set => this.swiftCode = value;
        }

        public int PaymentMethodId { get;  set; }
        public PaymentMethod PaymentMethod { get;  set; }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidNumber);
            }

            this.Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidNumber);
            }

            this.Balance += amount;
        }
    }
}
