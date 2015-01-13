namespace _04.PathAndSave
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using _01.StructurePoint3D;    

    class Path
    {
        // fields

        private List<Point3D> sequence;

        // properties

        public List<Point3D> Sequence
        {
            get { return new List<Point3D>(this.sequence); }
            private set { this.sequence = value; }
        }

        // constructors

        public Path()
        {
            this.Sequence = new List<Point3D>();
        }

        public Path(Point3D element)
            : this()
        {
            this.AddPoint(element);
        }

        public void AddPoint(Point3D point)
        {
            this.sequence.Add(point);
        }

        // ToString() overload

        public string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Sequence.Count; i++)
            {
                result.Append(this.Sequence[i].ToString());

                if (i != this.Sequence.Count - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }        
    }
}
