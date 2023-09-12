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
            int hour = 60;
            int timePerPerson = 10;
            int receptionLine;
            Console.WriteLine("How many people in reception line?");
            receptionLine = Convert.ToInt32(Console.ReadLine());
            int waitingHours = (receptionLine * timePerPerson) / hour;
            int waitingMinutes = (receptionLine * timePerPerson) % hour;
            Console.WriteLine("You will wait " + waitingHours + " hours and " + waitingMinutes + " minutes");
        }
    }
}
