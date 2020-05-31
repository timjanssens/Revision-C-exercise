using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class ResultV1
    {
        public int Result { get; set; }
        private void PrintHonors()
        {
            if (Result < 50)
                Console.WriteLine("Not passed");
            else if (Result < 68)
                Console.WriteLine("Cum Fructu");
            else if (Result < 75)
                Console.WriteLine("Cum Laude");
            else if (Result < 85)
                Console.WriteLine("Magna Cum Laude");
            else
                Console.WriteLine("Summa Cum Laude");
        }

        public static void Main()
        {
            Console.Clear();

            ResultV1 een = new ResultV1{Result = 48};
            ResultV1 twee = new ResultV1{Result = 51};
            ResultV1 drie = new ResultV1{Result = 69};
            ResultV1 vier = new ResultV1{Result = 78};
            ResultV1 vijf = new ResultV1{Result = 88};

            een.PrintHonors();
            twee.PrintHonors();
            drie.PrintHonors();
            vier.PrintHonors();
            vijf.PrintHonors();

            Console.ReadKey();
        }

    }
}
