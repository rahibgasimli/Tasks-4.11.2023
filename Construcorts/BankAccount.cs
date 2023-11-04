namespace Construcorts
{
    internal class BankAccount
    {
        public string AccountNumber;
        private double balance = 1300;
        public double cash;

        public double AddCash()
        {
            return balance + cash; 
        }

        public double MinusCash()
        {
            return balance - cash;
        }

    }
}
