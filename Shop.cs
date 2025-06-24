using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Shop
    {
        private string name;
        private string address;
        private string productType;

        public Shop(string name, string address, string productType)
        {
            this.name = name;
            this.address = address;
            this.productType = productType;
        }

        public void Input()
        {
            Console.Write("Введите название магазина: ");
            name = Console.ReadLine();
            Console.Write("Введите адрес магазина: ");
            address = Console.ReadLine();
            Console.Write("Введите тип товаров: ");
            productType = Console.ReadLine();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Название магазина: " + name);
            Console.WriteLine("Адрес: " + address);
            Console.WriteLine("Тип товаров: " + productType);
            Console.WriteLine();
        }
    }
}
