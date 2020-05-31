using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class Verjaardag
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Wanneer verjaar je?");
            Console.Write("Dag: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Maand: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Jaar: ");
            int year = int.Parse(Console.ReadLine());
            // DateTime birthDay = new DateTime(year, month, day);
            DateTime birthDayThisYear = new DateTime(DateTime.Now.Year, month, day);
            DateTime today = DateTime.Now;
            TimeSpan difference;
            if (birthDayThisYear > today)
                difference = birthDayThisYear - today.AddDays(-1);
            else
            {
                if (DateTime.IsLeapYear(today.Year))
                    difference = birthDayThisYear.AddYears(1) - today;
                else
                    difference = birthDayThisYear.AddYears(1) - today.AddDays(-1);
            }
            Console.WriteLine(difference.Days);
            Console.ReadKey();
        }
    }
}
