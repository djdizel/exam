using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class RectangleArea
    {
        private double length;
        private double width;

        public RectangleArea(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                Console.WriteLine("Ошибка: стороны должны быть положительными!");
                this.length = 1;
                this.width = 1;
            }
            else
            {
                this.length = length;
                this.width = width;
            }
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        public bool IsSquare()
        {
            if (length == width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
