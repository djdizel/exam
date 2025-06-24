using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Воспроизведение начато");
        }

        public void Pause()
        {
            Console.WriteLine("Воспроизведение на паузе");
        }

        public void Stop()
        {
            Console.WriteLine("Воспроизведение остановлено");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Запись начата");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запись на паузе");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }
    }
}
