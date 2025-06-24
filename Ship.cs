using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Ship : Vehicle
    {
        private int passengers;
        private string port;

        public Ship(int x, int y, double price, int speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Пассажиры: " + passengers);
            Console.WriteLine("Порт приписки: " + port);
        }
    }
}
