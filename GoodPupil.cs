using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string surname) : base(surname) { }

        public override void Study()
        {
            Console.WriteLine(surname + " учится хорошо!");
        }

        public override void Read()
        {
            Console.WriteLine(surname + " читает в хорошем темпе!");
        }

        public override void Write()
        {
            Console.WriteLine(surname + " пишет правильно!");
        }

        public override void Relax()
        {
            Console.WriteLine(surname + " отдыхает, занимаясь спортом!");
        }
    }
}
