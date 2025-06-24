using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Plane : Vehicle
    {
        private int altitude;
        private int passengers;

        public Plane(int x, int y, double price, int speed, int year, int altitude, int passengers)
            : base(x, y, price, speed, year)
        {
            this.altitude = altitude;
            this.passengers = passengers;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Высота: " + altitude + " м");
            Console.WriteLine("Пассажиры: " + passengers);
        }
    }
}
