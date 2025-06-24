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
            Player player = new Player();
            IPlayable playable = player;
            IRecodable recordable = player;

            playable.Play();
            playable.Pause();
            playable.Stop();

            recordable.Record();
            recordable.Pause();
            recordable.Stop();
        }
    }
}
