using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Product
    {
        private string name;
        private double price;
        private int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double CalculateTotalCost()
        {
            return price * quantity;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine("Общая стоимость: " + String.Format("{0:F2}", CalculateTotalCost()));
            Console.WriteLine();
        }

        public double Price
        {
            get { return price; }
        }
    }
}
