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
            Console.Write("Введите количество поездов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Train[] trains = new Train[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nВведите данные для поезда " + (i + 1) + ":");
                Console.Write("Пункт назначения: ");
                string destination = Console.ReadLine();
                Console.Write("Номер поезда: ");
                int trainNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Время отправления (чч:мм): ");
                DateTime departureTime = DateTime.Parse(Console.ReadLine());

                trains[i] = new Train(destination, trainNumber, departureTime);
            }

            // Сортировка по пункту назначения
            for (i = 0; i < trains.Length - 1; i++)
            {
                for (int j = 0; j < trains.Length - i - 1; j++)
                {
                    if (String.Compare(trains[j].Destination, trains[j + 1].Destination) > 0)
                    {
                        Train temp = trains[j];
                        trains[j] = trains[j + 1];
                        trains[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный список поездов:");
            for (i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Поезд " + (i + 1) + ":");
                trains[i].ShowInfo();
            }

            Console.Write("\nВведите номер поезда для поиска: ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == searchNumber)
                {
                    Console.WriteLine("\nНайден поезд:");
                    trains[i].ShowInfo();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Поезд с номером " + searchNumber + " не найден.");
            }
        }
    }
}
