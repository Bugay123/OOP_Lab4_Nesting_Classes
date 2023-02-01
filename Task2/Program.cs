namespace Task2;

/*Створити клас: Факультет. Створити клас Кафедра,
вкладений в клас Факультет. В класі Факультет створити 2
екземпляри класу Кафедра. В класі Кафедра реалізувати
методи:
1) Встановлення назви кафедри
2) Кількість викладачів кафедри (введення кількості).
В класі Кафедра створити індексатор для ініціалізації
дисциплін кафедри.
В класі Факультет створити метод для виклику методів класу
Кафедра
Наприклад:
Факультет: Комп.наук.
Кафедри: Комп.наук та ІПЗ, 10 викладачів
ВМ, 5 викладачів.
В методі main реалізувати тестування методів класу.*/

class Faculty
{
    public class Department
    {
        public string Name { get; set; }
        public int Teachers { get; set; }
        public string[] Subjects;

        public void GetName()
        {
          Console.WriteLine("Введіть назву кафедри");
          Name = Console.ReadLine();
        }
        public void GetTeachers()
        {
            Console.WriteLine("Кількість викладачів?");
            int t = int.Parse(Console.ReadLine());
            Teachers = t;
        }

        public string this[int index]
        {
            get => Subjects[index];
            set => Subjects[index] = value;

        }
    }
    Department dep1 = new Department {};
    Department dep2 = new Department {};
     public void GetDep()
    {
        dep1.GetName();
        dep1.GetTeachers();
        Console.WriteLine($"Кафедра1: {dep1.Name}\nВикладачів: {dep1.Teachers}");
        dep2.GetName();
        dep2.GetTeachers();
        Console.WriteLine($"Кафедра2: {dep2.Name}\nВикладачів: {dep2.Teachers}");
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

