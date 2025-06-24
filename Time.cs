using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            Normalize();
        }

        private void Normalize()
        {
            int totalSeconds = ToSeconds();
            if (totalSeconds < 0)
            {
                totalSeconds = 0;
            }
            hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;
        }

        public int ToSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        public Time Add(Time other)
        {
            int totalSeconds = ToSeconds() + other.ToSeconds();
            return new Time(totalSeconds / 3600, (totalSeconds % 3600) / 60, totalSeconds % 60);
        }

        public void ShowTime()
        {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds));
        }
    }
}
