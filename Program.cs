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
            AbstractHandler[] handlers = new AbstractHandler[3];
            handlers[0] = new XMLHandler();
            handlers[1] = new TXTHandler();
            handlers[2] = new DOCHandler();

            int i;
            for (i = 0; i < handlers.Length; i++)
            {
                Console.WriteLine("\nРабота с " + handlers[i].GetType().Name + ":");
                handlers[i].Create();
                handlers[i].Open();
                handlers[i].Change();
                handlers[i].Save();
            }
        }
    }
}
