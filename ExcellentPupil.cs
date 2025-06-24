using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class ExcellentPupil : Pupil
    {
        public ExcellentPupil(string surname) : base(surname) { }

        public override void Study()
        {
            Console.WriteLine(surname + " учится отлично!");
        }

        public override void Read()
        {
            Console.WriteLine(surname + " читает быстро и всё понимает!");
        }

        public override void Write()
        {
            Console.WriteLine(surname + " пишет аккуратно и точно!");
        }

        public override void Relax()
        {
            Console.WriteLine(surname + " отдыхает, решая головоломки!");
        }
    }
}
