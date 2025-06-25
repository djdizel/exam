using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Tovar
    {
        protected string name;
        protected double price;
        protected int kvo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Kvo
        {
            get { return kvo; }
            set { kvo = value; }
        }

        public Tovar(string name, double price, int kvo)
        {
            this.name = name;
            this.price = price;
            this.kvo = kvo;
        }

        public virtual double CalculateCost()
        {
            return price * kvo;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Товар: " + name);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
            Console.WriteLine("Количество: " + kvo);
            Console.WriteLine("Стоимость: " + String.Format("{0:F2}", CalculateCost()));
            Console.WriteLine();
        }
    }
}
