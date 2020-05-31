using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class NumberCombination
    {
        private int number1;

        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }

        private int number2;

        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        public double Sum() => Number1 + Number2;

        public double Difference() => Number1 - Number2;

        public double Product() => Number1 * Number2;

        public double Quotient()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("ERROR");
                return 0;
            }
            else
                return Number1 / (double)Number2;
        }





        public static void Main()
        {
            Console.Clear();

            NumberCombination pair1 = new NumberCombination();
            pair1.Number1 = 12;
            pair1.Number2 = 34;
            Console.WriteLine("Paar:" + pair1.Number1 + ", " + pair1.Number2);
            Console.WriteLine("Sum = " + pair1.Sum());
            Console.WriteLine("Verschil = " + pair1.Difference());
            Console.WriteLine("Product = " + pair1.Product());
            Console.WriteLine("Quotient = " + pair1.Quotient());


            Console.ReadKey();
        }

    }
}
