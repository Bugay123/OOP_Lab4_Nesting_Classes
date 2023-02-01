using System;
namespace Task3
{
    public partial class Faculty
    {
        public partial class Department
        {
            public void GetName(string n)
            {
                Name = n;
            }
            public void GetTeachers()
            {
                Console.WriteLine("Кількість викладачів?");
                int t = int.Parse(Console.ReadLine());
                Teachers = t;
            }
        }
    }
}
