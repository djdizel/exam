using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Triangle<T> where T : IComparable
    {
        private T a;
        private T b;
        private T c;

        public T A
        {
            get { return a; }
            set
            {
                if (Comparer<T>.Default.Compare(value, default(T)) <= 0)
                {
                    throw new ArgumentException("Сторона должна быть положительной!");
                }
                a = value;
            }
        }

        public T B
        {
            get { return b; }
            set
            {
                if (Comparer<T>.Default.Compare(value, default(T)) <= 0)
                {
                    throw new ArgumentException("Сторона должна быть положительной!");
                }
                b = value;
            }
        }

        public T C
        {
            get { return c; }
            set
            {
                if (Comparer<T>.Default.Compare(value, default(T)) <= 0)
                {
                    throw new ArgumentException("Сторона должна быть положительной!");
                }
                c = value;
            }
        }

        public Triangle(T a, T b, T c)
        {
            A = a;
            B = b;
            C = c;
            if (!IsValidTriangle(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c)))
            {
                throw new ArgumentException("Невозможно построить треугольник!");
            }
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }

        public double CalculateArea()
        {
            double aVal = Convert.ToDouble(a);
            double bVal = Convert.ToDouble(b);
            double cVal = Convert.ToDouble(c);
            double p = (aVal + bVal + cVal) / 2;
            return Math.Sqrt(p * (p - aVal) * (p - bVal) * (p - cVal));
        }

        public void ShowInfo()
        {
            Console.WriteLine("Треугольник со сторонами: " + a + ", " + b + ", " + c);
            Console.WriteLine("Площадь: " + String.Format("{0:F2}", CalculateArea()));
        }
    }
}
