using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Tovar
    {
        private string name;
        private double price;
        private int kvo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 1 && value <= 20)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Цена должна быть от 1 до 20!");
                }
            }
        }

        public int Kvo
        {
            get { return kvo; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    kvo = value;
                }
                else
                {
                    throw new ArgumentException("Количество должно быть от 0 до 10!");
                }
            }
        }

        public Tovar(string name, double price, int kvo)
        {
            this.name = name;
            Price = price; // Используем свойство
            Kvo = kvo; // Используем свойство
        }

        public double CalculateCost()
        {
            return price * kvo;
        }
    }
}
