using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите часы для первого времени: ");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты для первого времени: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды для первого времени: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Time time1 = new Time(h1, m1, s1);

            Console.Write("Введите часы для второго времени: ");
            int h2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты для второго времени: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды для второго времени: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Time time2 = new Time(h2, m2, s2);

            Console.WriteLine("\nПервое время: ");
            time1.ShowTime();
            Console.WriteLine("В секундах: " + time1.ToSeconds());

            Console.WriteLine("\nВторое время: ");
            time2.ShowTime();
            Console.WriteLine("В секундах: " + time2.ToSeconds());

            Console.WriteLine("\nСумма времён: ");
            Time sum = time1.Add(time2);
            sum.ShowTime();
        }
    }
}
