using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Obuv : Tovar
    {
        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Obuv(string name, double price, int kvo, int size)
            : base(name, price, kvo)
        {
            this.size = size;
        }

        public override double CalculateCost()
        {
            return price * kvo * 1.1; // Налог 10%
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Размер: " + size);
            Console.WriteLine();
        }
    }
}
