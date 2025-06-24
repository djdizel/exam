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
            Console.Write("Введите числитель первой дроби: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель первой дроби: ");
            int den1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите числитель второй дроби: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель второй дроби: ");
            int den2 = Convert.ToInt32(Console.ReadLine());

            Fraction fraction1 = new Fraction(num1, den1);
            Fraction fraction2 = new Fraction(num2, den2);

            Console.WriteLine("Первая дробь: " + fraction1.ToString());
            Console.WriteLine("Вторая дробь: " + fraction2.ToString());
            Console.WriteLine("Сложение: " + fraction1.Add(fraction2).ToString());
            Console.WriteLine("Вычитание: " + fraction1.Subtract(fraction2).ToString());
            Console.WriteLine("Умножение: " + fraction1.Multiply(fraction2).ToString());
            Console.WriteLine("Деление: " + fraction1.Divide(fraction2).ToString());
        }
    }
}
