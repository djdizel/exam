using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class BadPupil : Pupil
    {
        public BadPupil(string surname) : base(surname) { }

        public override void Study()
        {
            Console.WriteLine(surname + " учится плохо!");
        }

        public override void Read()
        {
            Console.WriteLine(surname + " читает медленно!");
        }

        public override void Write()
        {
            Console.WriteLine(surname + " пишет с ошибками!");
        }

        public override void Relax()
        {
            Console.WriteLine(surname + " отдыхает, смотря телевизор!");
        }
    }
}
