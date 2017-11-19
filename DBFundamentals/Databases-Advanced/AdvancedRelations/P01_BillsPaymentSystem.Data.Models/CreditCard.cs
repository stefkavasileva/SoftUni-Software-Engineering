using System;
using P01_BillsPaymentSystem.Data.Models.Constants;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class CreditCard
    {
        private decimal limit;
        private decimal moneyOwed;
        private DateTime expirationDate;

        public CreditCard(decimal limit, decimal moneyOwed, DateTime expirationDate)
        {
            this.Limit = limit;
            this.MoneyOwed = moneyOwed;
            this.ExpirationDate = expirationDate;
        }

        public CreditCard()
        {

        }

        public int CreditCardId { get;  set; }

        public decimal Limit
        {
            get => this.limit;
            private set => this.limit = value;
        }

        public decimal MoneyOwed
        {
            get => this.moneyOwed;
            private set => this.moneyOwed = value;
        }

        //calculated prop not included in the db
        public decimal LimitLeft => Limit - MoneyOwed;

        public DateTime ExpirationDate
        {
            get => this.expirationDate;
            private set => this.expirationDate = value;
        }

        public int PaymentMethodId { get;  set; }
        public PaymentMethod PaymentMethod { get;  set; }

        public void Withdraw(decimal amount)
        {
            if (amount > this.LimitLeft)
            {
                throw new ArgumentException(ErrorMessages.NotEnoughMoney);
            }

            this.MoneyOwed += amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new AggregateException(ErrorMessages.InvalidNumber);
            }

            if (amount <= this.MoneyOwed)
            {
                this.MoneyOwed += amount;
                return;
            }

            this.Limit += amount - this.MoneyOwed;
            this.MoneyOwed = 0;
        }
    }
}
