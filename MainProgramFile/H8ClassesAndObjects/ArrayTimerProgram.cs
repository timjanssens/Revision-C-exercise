using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class ArrayTimerProgram
    {
        public static void Main()
        {
            Console.Clear();

            DateTime start = DateTime.Now;
            int[] array = new int[1000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            DateTime end = DateTime.Now;

            TimeSpan difference = end - start;

            Console.WriteLine($"It takes {difference.TotalMilliseconds} to fill an array with one million digits.");

            Console.ReadKey();
        }

    }
}
