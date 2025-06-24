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
            Address address = new Address
            {
                Index = "220000",
                Country = "Беларусь",
                City = "Минск",
                Street = "Главная улица",
                House = 10,
                Apartment = 5
            };

            Console.WriteLine($"Индекс: {address.Index}");
            Console.WriteLine($"Страна: {address.Country}");
            Console.WriteLine($"Город: {address.City}");
            Console.WriteLine($"Улица: {address.Street}");
            Console.WriteLine($"Дом: {address.House}");
            Console.WriteLine($"Квартира: {address.Apartment}");
        }
    }
}
