using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Odejda : Tovar
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Odejda(string name, double price, int kvo, string color)
            : base(name, price, kvo)
        {
            this.color = color;
        }

        public override double CalculateCost()
        {
            return price * kvo * 1.15; // Налог 15%
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Цвет: " + color);
            Console.WriteLine();
        }
    }
}
