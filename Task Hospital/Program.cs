using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesInHour = 60;
            int minutesPerPerson = 10;
            int receptionLine;
            Console.WriteLine("How many people in reception line?");
            receptionLine = Convert.ToInt32(Console.ReadLine());
            int waitingMinutesInLine = (receptionLine * minutesPerPerson); 
            int supposedWaitingHours = waitingMinutesInLine / minutesInHour;
            int supposedWaitingMinutes = waitingMinutesInLine % minutesInHour;
            Console.WriteLine("You will wait " + supposedWaitingHours + " hours and " + supposedWaitingMinutes + " minutes");
        }
    }
}
