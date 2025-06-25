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
            Console.Write("Введите радиус окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radius);

            Console.WriteLine("Площадь окружности: " + String.Format("{0:F2}", circle.CalculateArea()));
            Console.WriteLine("Длина окружности: " + String.Format("{0:F2}", circle.CalculateCircumference()));
        }
    }
}
