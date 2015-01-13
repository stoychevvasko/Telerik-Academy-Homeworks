namespace Homework05
{
    using System;
    using System.Text;

    /// <summary>
    /// Represents any food item, its food quality, prep and cooked state and weight in grams.
    /// </summary>
    public class Vegetable
    {
        private bool isCooked;
        private bool isRotten;
        private bool isPeeled;
        private bool isCut;
        private float weight;

        public bool IsCooked
        {
            get { return this.isCooked; }
            set { this.isCooked = value; }
        }

        public bool IsRotten
        {
            get { return this.isRotten; }
            set { this.isRotten = value; }
        }

        public bool IsPeeled
        {
            get { return this.isPeeled; }
            set { this.isPeeled = value; }
        }

        public bool IsCut
        {
            get { return this.isCut; }
            set { this.isCut = value; }
        }

        public float Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Invalid weight! Must be a non-negative value.");
                }
                else
                {
                    this.weight = value;
                }
            }
        }

        public Vegetable(float weightArg, bool isPeeledArg, bool isCutArg, bool isCookedArg, bool isRottenArg)
        {
            this.Weight = weightArg;
            this.IsPeeled = isPeeledArg;
            this.IsCut = isCutArg;
            this.IsCooked = isCookedArg;
            this.IsRotten = isRottenArg;
        }

        public Vegetable()
            : this(100, false, false, false, false)
        {
            //default constructor
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("weight: {0}\n", this.Weight));
            result.Append(String.Format("peeled: {0}\n", this.IsPeeled));
            result.Append(String.Format("cut: {0}\n", this.IsCut));
            result.Append(String.Format("cooked: {0}\n", this.IsCooked));
            result.Append(String.Format("rotten: {0}\n\n", this.IsRotten));
            return result.ToString();
        }
    }

}

