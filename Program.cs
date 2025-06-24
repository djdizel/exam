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
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            MyArray myArray = new MyArray(size);
            int i;
            for (i = 0; i < size; i++)
            {
                Console.Write("Введите элемент [" + i + "]: ");
                myArray.SetElement(i, Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("\nИсходный массив:");
            myArray.Print();

            myArray.Sort();
            Console.WriteLine("Отсортированный массив:");
            myArray.Print();

            Console.WriteLine("Максимум: " + myArray.FindMax());
            Console.WriteLine("Минимум: " + myArray.FindMin());
            Console.WriteLine("Среднее значение: " + String.Format("{0:F2}", myArray.FindAverage()));
        }
    }
}
