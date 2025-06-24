using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Ошибка: знаменатель не может быть равен нулю!");
                denominator = 1;
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            int newNumerator = numerator * other.denominator + other.numerator * denominator;
            int newDenominator = denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Subtract(Fraction other)
        {
            int newNumerator = numerator * other.denominator - other.numerator * denominator;
            int newDenominator = denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Multiply(Fraction other)
        {
            int newNumerator = numerator * other.numerator;
            int newDenominator = denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Divide(Fraction other)
        {
            if (other.numerator == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return new Fraction(0, 1);
            }
            int newNumerator = numerator * other.denominator;
            int newDenominator = denominator * other.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }

}
