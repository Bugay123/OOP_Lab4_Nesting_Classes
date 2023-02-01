namespace Task3;

/*Часткові класи. Розбити клас Кафедра на 2 частини.*/

public partial class Faculty
{
    public partial class Department
    {
        public string Name { get; set; }
        public int Teachers { get; set; }
        public string[] Subjects;

        public string this[int index]
        {
            get => Subjects[index];
            set => Subjects[index] = value;
        }
    }
    Department dep1 = new Department { };
    Department dep2 = new Department { };

    public void GetDep()
    {
        dep1.GetName("Комп.наук");
        dep1.GetTeachers();
        Console.WriteLine($"Кафедра: {dep1.Name}\nВикладачів: {dep1.Teachers}");
        dep2.GetName("Комп.наук");
        dep2.GetTeachers();
        Console.WriteLine($"Кафедра: {dep2.Name}\nВикладачів: {dep2.Teachers}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var fac = new Faculty();
        fac.GetDep();
    }
}