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
            Invoice invoice = new Invoice(123456, "Иван Иванов", "ООО Поставщик");
            invoice.SetOrder("Ноутбук", 5);

            Console.Write("Введите цену за единицу: ");
            double price = Convert.ToDouble(Console.ReadLine());

            var (withVAT, withoutVAT) = invoice.CalculateCost(price);
            Console.WriteLine($"Стоимость без НДС: {withoutVAT:F2}");
            Console.WriteLine($"Стоимость с НДС: {withVAT:F2}");
        }
    }
}
