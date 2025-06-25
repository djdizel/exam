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
                Point<int> intPoint = new Point<int>(3, 4);
                Console.WriteLine("Точка с int:");
                intPoint.Show();

                Point<uint> uintPoint = new Point<uint>(5, 6);
                Console.WriteLine("\nТочка с uint:");
                uintPoint.Show();

                Point<double> doublePoint = new Point<double>(2.5, 3.7);
                Console.WriteLine("\nТочка с double:");
                doublePoint.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
