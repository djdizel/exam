using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Vector
    {
        private double x;
        private double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateLength()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double ScalarProduct(Vector other)
        {
            return x * other.x + y * other.y;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Вектор: (" + x + ", " + y + ")");
            Console.WriteLine("Длина вектора: " + String.Format("{0:F2}", CalculateLength()));
        }
    }
}
