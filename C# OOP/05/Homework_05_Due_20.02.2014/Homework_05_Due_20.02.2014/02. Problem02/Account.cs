/*
All accounts have customer, balance and interest rate (monthly based).
*/

namespace _02.Problem02
{
    using System;

    public abstract class Account
    {
        private Customer accountHolder;
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private decimal interestRate;

        public Customer AccountHolder
        {
            get { return this.accountHolder; }
            set
            {
                if (value == null)
                {
                    throw new System.ArgumentNullException("Account holder cannot be null!");
                }
                this.accountHolder = value;
            }
        }

        

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    value = (-1) * value;
                    // no negative interest rates
                }
                this.interestRate = value;
            }
        }

        public Account(Customer holder, decimal balance, decimal interestRate)
        {
            this.accountHolder = holder;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }        

        // I assume monthly capitalisation, interest rate is given as yearly percentage
        public abstract decimal AccrueInterest(uint months);

        static public void PrintAccount(Account acc, uint months)
        {
            string type = acc.GetType().ToString();
            Console.WriteLine("Type of account         {0}", type.Substring(type.LastIndexOf('.') + 1));
            Console.WriteLine("Account holder          {0}", acc.AccountHolder.Name);
            Console.WriteLine("Annual interest rate    {0:F} %", acc.InterestRate);
            Console.WriteLine("Current balance         {0:N} BGN", acc.Balance);
            Console.WriteLine("Balance in {0,-2} months    {1:N} BGN", months, acc.AccrueInterest(24));
            Console.WriteLine();
        }
    }
}
