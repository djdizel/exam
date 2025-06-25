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
                Tovar[] tovars = new Tovar[]
                {
                    new Obuv("Кроссовки", 100, 2, 42),
                    new Odejda("Футболка", 20, 5, "Синий"),
                    new Tovar("Книга", 10, 3)
                };

                int i;
                for (i = 0; i < tovars.Length; i++)
                {
                    Console.WriteLine("Товар " + (i + 1) + ":");
                    tovars[i].ShowInfo();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
