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
                Console.Write("Введите модель ноутбука: ");
                string model = Console.ReadLine();
                Console.Write("Введите производителя: ");
                string manufacturer = Console.ReadLine();
                Console.Write("Введите цену: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Notebook notebook = new Notebook(model, manufacturer, price);
                Console.WriteLine("\nИнформация о ноутбуке:");
                notebook.ShowInfo();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: цена должна быть числом!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
