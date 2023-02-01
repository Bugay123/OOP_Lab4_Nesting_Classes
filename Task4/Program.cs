namespace Task4;

/*Статичні класи. Розробити статичний клас з методами
1) Знайти методом лінійного пошуку максимальний і
мінімальний елементи в масиві {4,5,2,3,8,7,6,1}
2) Знайти методом двійкового пошуку потрібний елемент у
масиві розміру 100.
В методі main протестувати методи класу.*/

public static class MaxMin
{
    public static double GetMax(double[] mas)
    {
        return mas.Max();
    }
    public static double GetMin(double[] mas)
    {
        return mas.Min();
    }

    public static int BinarySearch(double[] array, int searchedValue, int first, int last)
    {
        if (first > last)
        {
            return -1;
        }

        var middle = (first + last) / 2;
        var middleValue = array[middle];

        if (middleValue == searchedValue)
        {
            return middle;
        }
        else
        {
            if (middleValue > searchedValue)
            {
                return BinarySearch(array, searchedValue, first, middle - 1);
            }
            else
            {
                return BinarySearch(array, searchedValue, middle + 1, last);
            }
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        double[] mas = { 4, 5, 2, 3, 8, 7, 6, 1 };
        double resMax = MaxMin.GetMax(mas);
        double resMin = MaxMin.GetMin(mas);
        Console.WriteLine($"Max - {resMax}, Min - {resMin}");
        Random rnd = new Random();
        double[] mas1 = new double[10];

        for (int i = 0; i <= mas1.Length - 1; i++)
        {
            mas1[i] = rnd.Next(1,10);
            Console.WriteLine(mas1[i]);
        }
        Array.Sort(mas1);
        var searchResult = MaxMin.BinarySearch(mas1, 2, 0, mas1.Length - 1);
        if (searchResult < 0)
        {
            Console.WriteLine($"Елемент зі значенням {2} не знайдено");
        }
        else
        {
            Console.WriteLine($"Елемент знайдено. Індекс елементу зі значенням {2} рівний {searchResult}");
        }
    }
}


