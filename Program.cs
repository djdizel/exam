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
            try
            {
                Product[] products = new Product[]
                {
                    new Product("Молоко", "Молочный завод", 2.5, 10, 100),
                    new Product("Хлеб", "Хлебозавод", 1.2, 5, 50),
                    new Product("Молоко", "Ферма", 3.0, 15, 80)
                };

                Console.Write("Введите наименование товара: ");
                string searchName = Console.ReadLine();
                Console.WriteLine("\nТовары с наименованием '" + searchName + "':");
                bool found = false;
                int i;
                for (i = 0; i < products.Length; i++)
                {
                    if (products[i].Name == searchName)
                    {
                        products[i].ShowInfo();
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Товары не найдены.");
                }

                Console.Write("\nВведите максимальную цену: ");
                double maxPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Товары с наименованием '" + searchName + "' и ценой не выше " + maxPrice + ":");
                found = false;
                for (i = 0; i < products.Length; i++)
                {
                    if (products[i].Name == searchName && products[i].Price <= maxPrice)
                    {
                        products[i].ShowInfo();
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Товары не найдены.");
                }

                Console.Write("\nВведите минимальный срок хранения (дней): ");
                int minShelfLife = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Товары со сроком хранения больше " + minShelfLife + " дней:");
                found = false;
                for (i = 0; i < products.Length; i++)
                {
                    if (products[i].ShelfLife > minShelfLife)
                    {
                        products[i].ShowInfo();
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Товары не найдены.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
