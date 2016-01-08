using System;

class Program
{
    static void Main()
    {
    TimeZone zone =  TimeZone.CurrentTimeZone;
    DateTime local = zone.ToLocalTime(DateTime.Now);
    Console.WriteLine(string.Format("Today is: {0}", local));

    }
}