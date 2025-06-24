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
            Printer printer = new Printer();
            Printer colorPrinter = new ColorPrinter();

            Console.Write("Введите строку для печати: ");
            string input = Console.ReadLine();

            printer.Print(input);
            if (colorPrinter is ColorPrinter)
            {
                ((ColorPrinter)colorPrinter).Print(input);
            }
        }
    }
}
