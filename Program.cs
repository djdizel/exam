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
            Console.Write("Введите первую сторону треугольника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            Triangle triangle = new Triangle(side1, side2, side3);

            if (triangle.Exists())
            {
                Console.WriteLine("Треугольник существует.");
                Console.WriteLine("Площадь треугольника: " + String.Format("{0:F2}", triangle.CalculateArea()));
            }
            else
            {
                Console.WriteLine("Треугольник не существует.");
            }
        }
    }
}
