using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    struct Train
    {
        private string destination;
        private int trainNumber;
        private DateTime departureTime;

        public Train(string destination, int trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public string Destination
        {
            get { return destination; }
        }

        public int TrainNumber
        {
            get { return trainNumber; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Пункт назначения: " + destination);
            Console.WriteLine("Номер поезда: " + trainNumber);
            Console.WriteLine("Время отправления: " + departureTime.ToString("HH:mm"));
            Console.WriteLine();
        }
    }
}
