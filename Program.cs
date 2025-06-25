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
            Console.Write("Введите длину прямоугольника: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            double width = Convert.ToDouble(Console.ReadLine());

            RectangleArea rectangle = new RectangleArea(length, width);

            Console.WriteLine("Площадь: " + String.Format("{0:F2}", rectangle.CalculateArea()));
            Console.WriteLine("Периметр: " + String.Format("{0:F2}", rectangle.CalculatePerimeter()));
            if (rectangle.IsSquare())
            {
                Console.WriteLine("Это квадрат.");
            }
            else
            {
                Console.WriteLine("Это не квадрат.");
            }
        }
    }
}
