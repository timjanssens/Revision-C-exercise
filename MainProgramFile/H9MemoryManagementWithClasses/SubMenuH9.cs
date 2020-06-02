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
                Console.WriteLine("2. Consious Pokemon");
                Console.WriteLine("3. Consious Pokemon Safe");
                Console.WriteLine("4. Poke Value or reference");
                Console.WriteLine("5. PokeFight");
                Console.WriteLine("5. PokeFight imporved");
                Console.WriteLine("r. Return to main menu");
                Console.WriteLine("q. End Program");
                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        PokeProgram.MakePokemon();
                        break;
                    case '2':
                        PokeProgram.TestConsiousPokemon();
                        break;
                    case '3':
                        PokeProgram.testConsiousPokemonSafe();
                        break;
                    case '4':
                        PokeProgram.DemoRestoreHP();
                        break;
                    case '5':
                        PokeProgram.DemoFightOutcome();
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
