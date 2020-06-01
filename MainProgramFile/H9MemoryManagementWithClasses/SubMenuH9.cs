using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H9MemoryManagementWithClasses
{
    class SubMenuH9
    {

        public static void Main()
        {
            bool keepMenu = true;

            while (keepMenu)
            {

                Console.Clear();
                Console.WriteLine("H9 Memory management with classes.");
                Console.WriteLine("**********************************");
                Console.WriteLine("1. PokeAttack");
                Console.WriteLine("");
                Console.WriteLine("r. Return to main menu");
                Console.WriteLine("q. End Program");
                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        PokeProgram.MakePokemon();
                        break;

                    case 'r':
                        keepMenu = false;
                        break;
                    case 'q':
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

            }




        }

    }
}
