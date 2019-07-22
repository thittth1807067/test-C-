namespace ConsoleApp1
{
    public class People
    {
        public string name;
        public bool gender;
        public int age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public bool Gender
        {
            get => gender;
            set => gender = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public People(string name, bool gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Person detail: Name = {Name}, Gender = Male, Age = {Age}  ";
        }
    }
    
}