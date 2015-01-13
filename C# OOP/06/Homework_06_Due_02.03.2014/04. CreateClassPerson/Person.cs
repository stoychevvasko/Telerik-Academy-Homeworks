namespace _04.CreateClassPerson
{
    using System;
    using System.Text;

    public class Person
    {
        #region fields

        private string name;
        private byte? age;

        #endregion

        #region properties

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new System.ArgumentNullException("Name cannot be empty or null!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public byte? Age
        {
            get { return this.age; }
            set
            {
                if (value > 130)
                {
                    throw new System.ArgumentOutOfRangeException("Invalid age! Only values from 0 to 130 are allowed!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        #endregion

        #region constructors

        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
            : this(name, null)
        {
        }

        public Person()
            : this("NoName", null)
        {
        }

        #endregion

        #region method overrides

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(String.Format("Name:          {0}\n", this.Name));

            if (this.Age != null)
            {
                result.Append(String.Format("Age:           {0}\n", this.Age));
            }
            else
            {
                result.Append("Age:           unspecified\n");
            }            

            return result.ToString();
        }

        #endregion
    }
}
