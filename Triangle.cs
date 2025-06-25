using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Triangle
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public bool Exists()
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                return false;
            }
            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
            {
                return false;
            }
            return true;
        }

        public double CalculateArea()
        {
            if (!Exists())
            {
                Console.WriteLine("Треугольник не существует!");
                return 0;
            }
            double p = (side1 + side2 + side3) / 2; // Полупериметр
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
    }
}
