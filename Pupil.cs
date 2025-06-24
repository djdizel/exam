using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    abstract class Pupil
    {
        public string surname;

        public Pupil(string surname)
        {
            this.surname = surname;
        }

        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }
}
