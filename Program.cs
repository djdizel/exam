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
            Console.Write("Введите действительную часть первого числа: ");
            double real1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого числа: ");
            double imag1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите действительную часть второго числа: ");
            double real2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть второго числа: ");
            double imag2 = Convert.ToDouble(Console.ReadLine());

            Complex complex1 = new Complex(real1, imag1);
            Complex complex2 = new Complex(real2, imag2);

            Console.WriteLine("Первое число: " + complex1.ToString());
            Console.WriteLine("Второе число: " + complex2.ToString());
            Console.WriteLine("Сложение: " + complex1.Add(complex2).ToString());
            Console.WriteLine("Вычитание: " + complex1.Subtract(complex2).ToString());
            Console.WriteLine("Умножение: " + complex1.Multiply(complex2).ToString());
        }
    }
}
