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
            Console.Write("Введите длину первой стороны: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второй стороны: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Периметр: {rectangle.Perimeter}");
            Console.WriteLine($"Площадь: {rectangle.Area}");
        }
    }
}
