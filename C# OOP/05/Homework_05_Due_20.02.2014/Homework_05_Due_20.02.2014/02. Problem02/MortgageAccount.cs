namespace _02.Problem02
{
    public class MortgageAccount
        : Account, IDepositable
    {
        public MortgageAccount(Customer holder, decimal balance, decimal interestRate)
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
                for (int i = 6; i < months; i++)
                {
                    result *= (1 + (this.InterestRate / 100M / 12M));
                }
                return result;
            }
            else if (type.CompareTo("Company") == 0)
            {
                if (months <= 12)
                {
                    for (int i = 0; i < months; i++)
                    {
                        result *= (1 + (this.InterestRate / 2M / 100M / 12M));
                    }
                    return result;
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        result *= (1 + (this.InterestRate / 2M / 100M / 12M));
                    }

                    for (int j = 12; j < months; j++)
                    {
                        result *= (1 + (this.InterestRate / 100M / 12M));
                    }
                    return result;
                }
            }
            else
            {
                return result;
            }            
        }

    }
}

