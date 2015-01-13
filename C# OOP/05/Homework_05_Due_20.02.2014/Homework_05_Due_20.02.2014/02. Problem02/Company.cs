namespace _02.Problem02
{
    public class Company
        : Customer
    {
        public Company(string companyName)
            : base(companyName)
        {
        }

        public Company()
            : this("Unknown company")
        {
        }
    }
}
