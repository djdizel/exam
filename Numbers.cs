using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Numbers
    {
        private double number1;
        private double number2;

        public Numbers(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public double Add()
        {
            return number1 + number2;
        }

        public double Subtract()
        {
            return number1 - number2;
        }

        public double Multiply()
        {
            return number1 * number2;
        }

        public double Divide()
        {
            if (number2 == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            return number1 / number2;
        }

        public string Compare()
        {
            if (number1 > number2)
            {
                return "Большее число: " + number1;
            }
            else if (number1 < number2)
            {
                return "Большее число: " + number2;
            }
            else
            {
                return "Числа равны";
            }
        }
    }
}
