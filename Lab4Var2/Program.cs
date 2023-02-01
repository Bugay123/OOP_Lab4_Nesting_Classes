namespace Task1;

/*Вкладення класів. Модифікувати приклад 5.2 таким чином,
щоб можна було обчислювати середній рейтинг за 2 модулі (за
семестр).
Порядок виконання.
В методі StRating () заповнення масиву зробити випадковими
числами від 56 до 100. Згенерувати 10 чисел для 10 дисциплін.
В класі Student створити 2 екземпляри класу St_Assesment
St_Assesment strating1 = new St_Assesment();
St_Assesment strating2 = new St_Assesment();
Визначити рейтинги за кожний модуль в методі MyRating() та
середній рейтинг за семестр.*/

class Person
{
    //властивості
    public string Name { get; set; } //ім&#39;я
    public int Age { get; set; } // вік
    public string Role { get; set; } // роль
    public Person(string n, string r, int a)
    {
        Name = n;
        Age = a;
        Role = r;
    }
    public string GetName() { return Name; }
    public virtual void MyRating() { return; }
}
//class St_Assesment part of Student
class St_Assesment
{
    string[] subject = { "C#", "ООП", "Основи SE" };
    double[] assesment = new double[10];
    public double StRating()
    {
        Random random = new Random();
        double rating = 0;
        for (int i = 0; i < assesment.Length; i++)
        {
            assesment[i] = random.Next(56, 100);
            rating += assesment[i];
        }
        return rating / assesment.Length;
    }
}
//class Student
class Student : Person
{
    public string Facultet { get; set; }
    public string Group { get; set; }
    public int Course { get; set; }
    public Student(string n, string r, int a, string f, string g, int c)
    : base(n, r, a)
    {
        //конструктор з параметрами
        Name = n;
        Age = a;
        Role = r;
        Facultet = f;
        Group = g;
        Course = c;
    }
    //Створення екземпляра класу St_Assesment
    St_Assesment strating1 = new St_Assesment();
    St_Assesment strating2 = new St_Assesment();
    //
    public override void MyRating()
    {
        //обчислення рейтингу
        double ratingModule1 = strating1.StRating();
        Console.WriteLine("Рейтинг студента за 1 модуль = " + ratingModule1);
        double ratingModule2 = strating2.StRating();
        Console.WriteLine("Рейтинг студента за 2 модуль = " + ratingModule2);
        double Rating = Math.Round(((ratingModule1 + ratingModule2) / 2), 1);
        Console.WriteLine("Рейтинг студента за семестр = " + Rating);

        if (ratingModule1 >= 82) { Console.WriteLine("Привіт відмінникам"); }
        else
        {
            if (ratingModule1 <= 60)
            {
                Console.WriteLine("Перездача! Треба краще вчитися!");
            }
            else
            {
                Console.WriteLine("Можна вчитися ще краще!");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        //створення екземпляра newSt
        Student newSt = new Student("Іванов", "студент", 19, "КННІ", "ПІ - 21", 3);
        Console.WriteLine("Прізвище = " + newSt.Name);
        Console.WriteLine("Вік = " + newSt.Age);
        Console.WriteLine("Факультет = " + newSt.Facultet);
        Console.WriteLine("група = " + newSt.Group);
        Console.WriteLine("курс = " + newSt.Course);
        newSt.MyRating();
        Console.ReadKey();
    }
}