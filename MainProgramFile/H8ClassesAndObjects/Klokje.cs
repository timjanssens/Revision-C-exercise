using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class Klokje
    {
       public static void Main()
        {
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                Console.Clear();
                Console.WriteLine("Press ESC to exit.");
                Console.Write(DateTime.Now.ToString("HH:mm:ss"));
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
