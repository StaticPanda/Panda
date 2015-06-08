using System;
using Panda.Samples.Union;
using Panda.Union;

namespace Panda.Samples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Type anything to exit.");
            do
            {
                Meeting meeting = randomMeeting();
                meeting.Match(
                    oneTime => Console.WriteLine("One time at {0}", oneTime.Occurrence),
                    multiple => Console.WriteLine("Multiple - {0} times", multiple.Occurrences.Count),
                    periodic => Console.WriteLine("Periodic - every {0}", periodic.Period));
            } while (Console.ReadLine() == "");
        }

        private static Meeting randomMeeting()
        {
            var rnd = new Random();
            switch (rnd.Next(3))
            {
                case 0:
                    return new OneTimeMeeting(DateTime.Now);
                case 1:
                    return new MultipleTimesMeeting(new[] {DateTime.Now, DateTime.Now + TimeSpan.FromDays(2)});
                case 2:
                    return new PeriodicMeeting(DateTime.Now, TimeSpan.FromDays(3));
                default:
                    throw new Exception("Wat.");
            }
        }
    }
}