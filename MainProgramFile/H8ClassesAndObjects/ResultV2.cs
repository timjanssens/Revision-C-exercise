using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class ResultV2
    {
        public byte Result { get; set; }

        public Honors ComputeHonors()
        {
            Honors resultHonor;

            if (Result < 50)
                resultHonor = Honors.NotPassed;
            else if (Result < 68)
                resultHonor = Honors.CumFructu;
            else if (Result < 75)
                resultHonor = Honors.CumLaude;
            else if (Result < 85)
                resultHonor = Honors.MagnaCumLaude;
            else
                resultHonor = Honors.SummaCumLauda;
            return resultHonor;
        }

        public static void Main()
        {
            Console.Clear();

            ResultV2 eerste = new ResultV2 { Result = 40 };
            ResultV2 tweede = new ResultV2 { Result = 60 };
            ResultV2 derde = new ResultV2 { Result = 70 };
            ResultV2 vierde = new ResultV2 { Result = 80 };
            ResultV2 vijfde = new ResultV2 { Result = 90 };

            Console.WriteLine(eerste.ComputeHonors());
            Console.WriteLine(tweede.ComputeHonors());
            Console.WriteLine(derde.ComputeHonors());
            Console.WriteLine(vierde.ComputeHonors());
            Console.WriteLine(vijfde.ComputeHonors());

            Console.ReadKey();

        }
    }
}
