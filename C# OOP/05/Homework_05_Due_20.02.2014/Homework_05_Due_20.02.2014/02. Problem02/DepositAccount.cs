namespace _02.Problem02
{
    public class DepositAccount
        : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer holder, decimal balance, decimal interestRate)
            : base(holder, balance, interestRate)
        {
        }
                
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new System.ArgumentException("Cannot deposit non-positive amounts!");
            }
            
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new System.ArgumentException("Cannot withdraw non-positive amounts!");
            }

            this.Balance -= amount;
        }

        public override decimal AccrueInterest(uint months)
        {
            decimal result = this.Balance;

            // Deposit accounts have no interest if their balance is  
            // positive and less than 1000. 

            if (this.Balance > 0M && this.Balance <= 1000M)
            {
                return this.Balance;
            }

            for (int i = 0; i < months; i++)
            {
                result *= (1 + (this.InterestRate / 100M / 12M));
            }

            return result;
        }
    }
}
