namespace _02.Problem02
{
    public abstract class Customer
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == "" || value == null)
                {
                    throw new System.ArgumentNullException("Customer's name cannot be empty or null!");
                }

                this.name = value;
            }
        }

        public Customer(string name)
        {
            this.Name = name;
        }

        public Customer()
            : this("Unknown customer")
        {
        }


    }
}
