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
            List<Person> peopleList = new List<Person>();
            peopleList.Add(new Person("Иван", 25));
            peopleList.Add(new Person("Анна", 30));
            peopleList.Add(new Person("Борис", 22));
            peopleList.Add(new Person("Елена", 28));

            SortedSet<Person> peopleSet = new SortedSet<Person>(peopleList);

            Console.WriteLine("Список людей, отсортированный по имени:");
            peopleList.Sort();
            foreach (Person p in peopleList)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nМножество людей, отсортированное по имени:");
            foreach (Person p in peopleSet)
            {
                Console.WriteLine(p);
            }
        }
    }
}
