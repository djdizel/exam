using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Point<T>
    {
        private T x;
        private T y;

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine($"Точка: ({x}, {y})");
        }
    }
}
