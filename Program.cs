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
            MyClass myClass = new MyClass();
            Console.WriteLine("Число PI: " + myClass.GetPI());
            Console.WriteLine("Целое число: " + myClass.GetInteger());
            Console.Write("Введите число для вычисления квадрата: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Квадрат числа: " + myClass.Square(x));
            Console.Write("Введите число для вычисления корня: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Квадратный корень: " + myClass.Sqrt(x));
        }
    }
}
