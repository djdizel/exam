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
            Point p1 = new Point(0, 0, "A");
            Point p2 = new Point(0, 3, "B");
            Point p3 = new Point(4, 0, "C");
            Point p4 = new Point(4, 3, "D");

            Figure figure = new Figure(p1, p2, p3, p4);
            figure.PerimeterCalculator();
        }
    }
}
