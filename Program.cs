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
            Console.Write("Введите начальное значение счётчика: ");
            int initialCount = Convert.ToInt32(Console.ReadLine());

            Counter counter = new Counter(initialCount);

            Console.WriteLine("Текущее значение счётчика: " + counter.Count);
            counter.Increment();
            Console.WriteLine("После увеличения: " + counter.Count);
            counter.Increment();
            Console.WriteLine("После ещё одного увеличения: " + counter.Count);
            counter.Decrement();
            Console.WriteLine("После уменьшения: " + counter.Count);
        }
    }
}
