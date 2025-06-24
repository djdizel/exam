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
            Console.Write("Введите количество магазинов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Shop[] shops = new Shop[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nВведите данные для магазина " + (i + 1) + ":");
                shops[i] = new Shop("", "", "");
                shops[i].Input();
            }

            Console.WriteLine("\nИнформация о магазинах:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Магазин " + (i + 1) + ":");
                shops[i].ShowInfo();
            }
        }
    }
}
