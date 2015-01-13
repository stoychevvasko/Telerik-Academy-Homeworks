namespace _02.Problem02
{
    public class LoanAccount
        : Account, IDepositable
    {
        public LoanAccount(Customer holder, decimal balance, decimal interestRate)
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

        public override decimal AccrueInterest(uint months)
        {
            decimal result = this.Balance;
            
            string fullType = this.AccountHolder.GetType().ToString();
            string type = fullType.Substring(fullType.LastIndexOf('.') + 1);

            if (type.CompareTo("Individual") == 0)
            {
                for (int i = 3; i < months; i++)
                {
                    result *= (1 + (this.InterestRate / 100M / 12M));
                }
                return result;
            }
            else if (type.CompareTo("Company") == 0)
            {
                for (int i = 2; i < months; i++)
                {
                    result *= (1 + (this.InterestRate / 100M / 12M));
                }
                return result;
            }
            else
            {
                return result;
            }   
        }
    }
}
