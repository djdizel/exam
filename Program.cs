using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество продуктов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Product[] products = new Product[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nВведите данные для продукта " + (i + 1) + ":");
                Console.Write("Название: ");
                string name = Console.ReadLine();
                Console.Write("Цена: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Количество: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                products[i] = new Product(name, price, quantity);
            }

            Console.WriteLine("\nПродукт с минимальной ценой:");
            int minIndex = 0;
            double minPrice = products[0].Price;
            for (i = 1; i < n; i++)
            {
                if (products[i].Price < minPrice)
                {
                    minPrice = products[i].Price;
                    minIndex = i;
                }
            }
            products[minIndex].ShowInfo();
        }
    }
}
