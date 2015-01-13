namespace _02.StudentsAndWorkers
{
    public class Worker
        : Human
    {
        private float weekSalary;
        private float workHoursPerDay;

        public float WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Salary cannot be negative!");
                }

                this.weekSalary = value;
            }
        }

        public float WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < 0 || value > 24)
                {
                    throw new System.ArgumentOutOfRangeException("Invalid work hours!");
                }

                this.workHoursPerDay = value;
            }
        }

        public Worker(string fName, string lName, float wSalary, float wHoursPerDay)
            : base(fName, lName)
        {
            this.WeekSalary = wSalary;
            this.workHoursPerDay = wHoursPerDay;
        }

        public Worker()
            : base()
        {
            this.WeekSalary = 0;
            this.workHoursPerDay = 0;
        }

        public float MoneyPerHour()
        {
            return (this.WeekSalary / 5 / this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}      {2:C}/час", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
