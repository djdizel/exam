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
                Tovar[] tovars = new Tovar[2];
                tovars[0] = new Tovar("Книга", 15, 5);
                tovars[1] = new Tovar("Ручка", 2, 8);

                double totalCost = 0;
                int i;
                for (i = 0; i < tovars.Length; i++)
                {
                    double cost = tovars[i].CalculateCost();
                    totalCost += cost;
                    Console.WriteLine("Товар: " + tovars[i].Name);
                    Console.WriteLine("Цена: " + String.Format("{0:F2}", tovars[i].Price));
                    Console.WriteLine("Количество: " + tovars[i].Kvo);
                    Console.WriteLine("Стоимость: " + String.Format("{0:F2}", cost));
                    Console.WriteLine();
                }
                Console.WriteLine("Общая стоимость: " + String.Format("{0:F2}", totalCost));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
