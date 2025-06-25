using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Segment<T>
    {
        private T x1, y1, x2, y2;

        public T X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public T Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public T X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public T Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double CalculateLength()
        {
            double dx = Convert.ToDouble(x2) - Convert.ToDouble(x1);
            double dy = Convert.ToDouble(y2) - Convert.ToDouble(y1);
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Отрезок: [({x1}, {y1}), ({x2}, {y2})]");
            Console.WriteLine($"Длина: {CalculateLength():F2}");
            Console.WriteLine();
        }
    }
}
