using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class DayOfWeekProgram
    {
        public static void Main()
        {
            CultureInfo belgiumCI = new CultureInfo("nl-BE");

            Console.Clear();
            Console.WriteLine("When where you born?");
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime givenDate = new DateTime(year, month, day);

            Console.WriteLine($"{givenDate.ToString("dd MMMM yyyy", belgiumCI)} is a {givenDate.ToString("dddd", belgiumCI)}.");
 
            Console.ReadKey();
        }


    }
}
