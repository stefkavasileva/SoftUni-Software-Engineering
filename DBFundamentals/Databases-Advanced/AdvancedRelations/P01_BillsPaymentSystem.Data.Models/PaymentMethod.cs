using P01_BillsPaymentSystem.Data.Models.Enumerations;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class PaymentMethod
    {
        public PaymentMethod()
        {
            
        }

        public PaymentMethod(User user,CreditCard creditCard,PaymentType type)
        {
            this.User = user;
            this.CreditCard = creditCard;
            this.Type = type;
        }

        public PaymentMethod(User user, BankAccount bancAccount, PaymentType type)
        {
            this.User = user;
            this.BankAccount = bancAccount;
            this.Type = type;
        }

        //test check constraint
        //public PaymentMethod(User user, BankAccount bancAccount,CreditCard creditCard, PaymentType type)
        //{
        //    this.User = user;
        //    this.BankAccount = bancAccount;
        //    this.CreditCard = creditCard;
        //    this.Type = type;
        //}

        public int Id { get;  set; }

        public PaymentType Type { get; set; }

        public int UserId { get;  set; }
        public User User { get; set; }

        public int? BankAccountId { get;  set; }
        public BankAccount BankAccount { get;  set; }

        public int? CreditCardId { get;  set; }
        public CreditCard CreditCard { get;  set; }
    }
}
