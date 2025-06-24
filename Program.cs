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
            Console.Write("Введите ключ доступа (pro, exp или пусто для бесплатной версии): ");
            string key = Console.ReadLine().ToLower();

            DocumentWorker worker;
            if (key == "pro")
            {
                worker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                worker = new ExpertDocumentWorker();
            }
            else
            {
                worker = new DocumentWorker();
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}
