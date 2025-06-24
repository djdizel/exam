using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Car : Vehicle
    {
        public Car(int x, int y, double price, int speed, int year)
            : base(x, y, price, speed, year)
        {
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
