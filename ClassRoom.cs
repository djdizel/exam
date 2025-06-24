using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(Pupil p1, Pupil p2)
        {
            pupils = new Pupil[4];
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = null;
            pupils[3] = null;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            pupils = new Pupil[4];
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = null;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils = new Pupil[4];
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        public void ShowPupils()
        {
            int i;
            for (i = 0; i < pupils.Length; i++)
            {
                if (pupils[i] != null)
                {
                    Console.WriteLine($"\nУченик:{pupils[i].surname}");
                    pupils[i].Study();
                    pupils[i].Read();
                    pupils[i].Write();
                    pupils[i].Relax();
                }
            }
        }
    }
}
