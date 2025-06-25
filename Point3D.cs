using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double DistanceTo(Point3D other)
        {
            return Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2) + Math.Pow(z - other.z, 2));
        }

        public void ShowInfo()
        {
            Console.WriteLine("Координаты: (" + x + ", " + y + ", " + z + ")");
        }
    }
}
