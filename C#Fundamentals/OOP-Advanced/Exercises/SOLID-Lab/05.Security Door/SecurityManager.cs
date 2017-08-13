namespace _05.Security_Door
{
    using System;

    public class SecurityManager
    {
        private KeyCardCheck keyCardCheck;
        private PinCodeCheck pinCodeCheck;

        public SecurityManager(KeyCardCheck keyCardCheck, PinCodeCheck pinCodeCheck)
        {
            this.keyCardCheck = keyCardCheck;
            this.pinCodeCheck = pinCodeCheck;
        }

        public void Check()
        {
            Console.WriteLine("Choose option: 1 - KeyCard, 2 - PinCode:");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(this.keyCardCheck.ValidateUser());
                    break;
                case 2:
                    Console.WriteLine(this.pinCodeCheck.ValidateUser());
                    break;
            }
        }
    }
}