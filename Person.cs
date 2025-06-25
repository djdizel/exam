using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Person : IComparable
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(object obj)
        {
            Person other = obj as Person;
            if (other == null)
            {
                throw new ArgumentException("Объект не является Person");
            }
            return name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return "Имя: " + name + ", Возраст: " + age;
        }
    }
}
