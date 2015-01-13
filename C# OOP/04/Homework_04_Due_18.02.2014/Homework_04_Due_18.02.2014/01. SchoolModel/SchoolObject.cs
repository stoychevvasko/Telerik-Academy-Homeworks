namespace _01.SchoolModel
{
    public abstract class SchoolObject
    {
        private string comment;

        public string Comment
        {
            get { return this.comment; }
            protected set { this.comment = value; }
        }

        public SchoolObject(string msg)
        {
            this.Comment = msg;
        }

        public SchoolObject()
            : this("")
        {
        }
    }
}
