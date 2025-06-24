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
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Numbers numbers = new Numbers(num1, num2);

            Console.WriteLine("Сложение: " + String.Format("{0:F2}", numbers.Add()));
            Console.WriteLine("Вычитание: " + String.Format("{0:F2}", numbers.Subtract()));
            Console.WriteLine("Умножение: " + String.Format("{0:F2}", numbers.Multiply()));
            Console.WriteLine("Деление: " + String.Format("{0:F2}", numbers.Divide()));
            Console.WriteLine(numbers.Compare());
        }
    }
}
