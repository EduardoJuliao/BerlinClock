using System;
using System.Threading;
using BerlinClock;

namespace BerlinClockConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Continuously();
        }

        /// <summary>
        /// Feature test case
        /// </summary>
        static void RunCases()
        {
            Console.WriteLine(new TimeConverter().convertTime("00:00:00"));
            Console.WriteLine(new TimeConverter().convertTime("13:17:01"));
            Console.WriteLine(new TimeConverter().convertTime("23:59:59"));
            Console.WriteLine(new TimeConverter().convertTime("24:00:00"));
        }

        /// <summary>
        /// Prompt user to insert a time
        /// </summary>
        static void RunAsk()
        {
            Console.Write("Please, inform a time: ");
            var time = Console.ReadLine();

            var berlinTime = new TimeConverter().convertTime(time);

            Console.WriteLine(berlinTime);
            Console.ReadKey();
        }

        /// <summary>
        /// Runs Continuously
        /// </summary>
        static void Continuously()
        {
            while (true)
            {
                var berlinTime = new TimeConverter().convertTime(DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine(berlinTime);
                Thread.Sleep(999);
                Console.Clear();
            }
        }
    }
}
