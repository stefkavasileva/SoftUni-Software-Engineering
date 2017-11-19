using System.Collections.Generic;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        public User(string firstName, string lastName, string email, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.PaymentMethods = new List<PaymentMethod>();
        }

        public User()
        {
            this.PaymentMethods = new List<PaymentMethod>();
        }
  
        public int UserId { get;  set; }

        public string FirstName
        {
            get => this.firstName;
            private set => this.firstName = value;
        }

        public string LastName
        {
            get => this.lastName;
            private set => this.lastName = value;
        }

        public string Email
        {
            get => this.email;
            private set => this.email = value;
        }

        public string Password
        {
            get => this.password;
            private set => this.password = value;
        }

        public ICollection<PaymentMethod> PaymentMethods { get; set; } 
    }
}
