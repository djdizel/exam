using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class MyClass : InterfaceC
    {
        public void ShowInterfaceA()
        {
            Console.WriteLine("Метод InterfaceA");
        }

        public void ShowInterfaceB()
        {
            Console.WriteLine("Метод InterfaceB");
        }

        public void ShowInterfaceC()
        {
            Console.WriteLine("Метод InterfaceC");
        }
    }
}
