using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Ошибка: радиус не может быть отрицательным!");
                this.radius = 0;
            }
            else
            {
                this.radius = radius;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
