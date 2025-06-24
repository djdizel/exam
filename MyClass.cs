using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class MyClass : IMath
    {
        public double GetPI()
        {
            return Math.PI;
        }

        public int GetInteger()
        {
            return 42;
        }

        public double Square(double x)
        {
            return x * x;
        }

        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
