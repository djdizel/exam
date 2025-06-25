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
            Console.Write("Введите x для первой точки: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y для первой точки: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите z для первой точки: ");
            double z1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x для второй точки: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y для второй точки: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите z для второй точки: ");
            double z2 = Convert.ToDouble(Console.ReadLine());

            Point3D point1 = new Point3D(x1, y1, z1);
            Point3D point2 = new Point3D(x2, y2, z2);

            Console.WriteLine("\nПервая точка:");
            point1.ShowInfo();
            Console.WriteLine("Вторая точка:");
            point2.ShowInfo();
            Console.WriteLine("Расстояние между точками: " + String.Format("{0:F2}", point1.DistanceTo(point2)));
        }
    }
}
