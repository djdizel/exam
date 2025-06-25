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
        private string manufacturer;
        private double price;
        private int shelfLife;
        private int quantity;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int ShelfLife
        {
            get { return shelfLife; }
            set { shelfLife = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product(string name, string manufacturer, double price, int shelfLife, int quantity)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.shelfLife = shelfLife;
            this.quantity = quantity;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Наименование: " + name);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
            Console.WriteLine("Срок хранения (дней): " + shelfLife);
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine();
        }
    }

}
