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
                List<TouristFirm> firms = new List<TouristFirm>
                {
                    new TouristFirm("Тур1", 2010, "1234567890", 100000),
                    new TouristFirm("Тур2", 2015, "0987654321", 150000),
                    new TouristFirm("Тур3", 2020, "1122334455", 80000)
                };

                Console.WriteLine("Список фирм:");
                int i;
                for (i = 0; i < firms.Count; i++)
                {
                    firms[i].ShowInfo();
                }

                Console.Write("Введите название фирмы для поиска: ");
                string searchName = Console.ReadLine();
                bool found = false;
                for (i = 0; i < firms.Count; i++)
                {
                    if (firms[i].Name == searchName)
                    {
                        Console.WriteLine("\nНайдена фирма:");
                        firms[i].ShowInfo();
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Фирма не найдена.");
                }

                double totalProfit = 0;
                int maxProfitIndex = 0;
                for (i = 0; i < firms.Count; i++)
                {
                    totalProfit += firms[i].Profit;
                    if (firms[i].Profit > firms[maxProfitIndex].Profit)
                    {
                        maxProfitIndex = i;
                    }
                }
                Console.WriteLine("Суммарная прибыль: " + String.Format("{0:F2}", totalProfit));
                Console.WriteLine("\nФирма с максимальной прибылью:");
                firms[maxProfitIndex].ShowInfo();

                Console.Write("Введите название фирмы для удаления: ");
                string removeName = Console.ReadLine();
                found = false;
                for (i = 0; i < firms.Count; i++)
                {
                    if (firms[i].Name == removeName)
                    {
                        firms.RemoveAt(i);
                        found = true;
                        Console.WriteLine("Фирма удалена.");
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Фирма не найдена.");
                }

                Console.WriteLine("\nДобавление новой фирмы:");
                Console.Write("Название: ");
                string newName = Console.ReadLine();
                Console.Write("Год создания: ");
                int newYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("ИНН: ");
                string newInn = Console.ReadLine();
                Console.Write("Прибыль: ");
                double newProfit = Convert.ToDouble(Console.ReadLine());
                firms.Add(new TouristFirm(newName, newYear, newInn, newProfit));

                Console.WriteLine("\nОбновлённый список фирм:");
                for (i = 0; i < firms.Count; i++)
                {
                    firms[i].ShowInfo();
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
