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
                Segment<int> intSegment = new Segment<int>(0, 0, 3, 4);
                Console.WriteLine("Отрезок с int:");
                intSegment.ShowInfo();

                Segment<long> longSegment = new Segment<long>(1, 2, 5, 6);
                Console.WriteLine("Отрезок с long:");
                longSegment.ShowInfo();

                Segment<double> doubleSegment = new Segment<double>(1.5, 2.5, 4.5, 6.5);
                Console.WriteLine("Отрезок с double:");
                doubleSegment.ShowInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
