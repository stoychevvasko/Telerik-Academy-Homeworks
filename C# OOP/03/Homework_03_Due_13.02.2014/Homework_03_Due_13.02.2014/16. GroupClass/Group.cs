namespace _16.GroupClass
{
    public class GroupC
    {
        public int GroupNumber { get; set; }
        public string Department { get; set; }
        public int ID { get; private set; }

        public GroupC(int groupNumber, string department, int id)
        {
            this.GroupNumber = groupNumber;
            this.Department = department;
            this.ID = id;
        }

        public GroupC()
            : this (0, "NoNameDepartment", 0)
        {
        }


    }
}
