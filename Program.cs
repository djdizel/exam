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
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Plane(100, 200, 5000000, 900, 2020, 10000, 150);
            vehicles[1] = new Car(300, 400, 30000, 180, 2018);
            vehicles[2] = new Ship(500, 600, 1000000, 50, 2015, 2000, "Майами");

            int i;
            for (i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine("Информация о транспортном средстве " + (i + 1) + ":");
                vehicles[i].ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
