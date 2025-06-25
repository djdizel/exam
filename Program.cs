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
            Console.Write("Введите x для первого вектора: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y для первого вектора: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x для второго вектора: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y для второго вектора: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Vector vector1 = new Vector(x1, y1);
            Vector vector2 = new Vector(x2, y2);

            Console.WriteLine("\nПервый вектор:");
            vector1.ShowInfo();
            Console.WriteLine("\nВторой вектор:");
            vector2.ShowInfo();
            Console.WriteLine("\nСкалярное произведение: " + String.Format("{0:F2}", vector1.ScalarProduct(vector2)));
        }
    }
}
