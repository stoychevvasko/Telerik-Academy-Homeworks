//02. Refactor the following examples to produce code with well-named identifiers in C#:

using System;

class MainClass
{
    enum Sex
    {
        Male,
        Female
    };

    class Human
    {
        public Sex sex { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public void CreateHuman(int age)
    {
        Human newHuman = new Human();
        newHuman.Age = age;
        if (age % 2 == 0)
        {
            newHuman.Name = "MaleName";
            newHuman.sex = Sex.Male;
        }
        else
        {
            newHuman.Name = "FemaleName";
            newHuman.sex = Sex.Female;
        }
    }
}
