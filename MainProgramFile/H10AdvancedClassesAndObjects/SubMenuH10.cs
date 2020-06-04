using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H10AdvancedClassesAndObjects
{
    class SubMenuH10
    {

        public static void Main()
        {
            bool keepMenu = true;

            while (keepMenu)
            {

                Console.Clear();
                Console.WriteLine("H10 Advanced Classes and objects.");
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Pokemon with contstructor");
                Console.WriteLine("2. Make Pokemon with chained constructor");
                Console.WriteLine("3. Pokemon Battle counter ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("5. ");
                Console.WriteLine("r. Return to main menu");
                Console.WriteLine("q. End Program");
                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        H9MemoryManagementWithClasses.PokeProgram.DemonstratePokemonWithConstructor();
                        break;
                    case '2':
                        H9MemoryManagementWithClasses.PokeProgram.ConstructPokemonChained();
                        break;
                    case '3':
                        H9MemoryManagementWithClasses.PokeProgram.DemonstrateCounter();
                        break;
                    case '4':
                        //  H9MemoryManagementWithClasses.PokeProgram.MakePokemon();
                        break;
                    case '5':
                        //  H9MemoryManagementWithClasses.PokeProgram.MakePokemon();
                        break;
                    case '6':
                        //  H9MemoryManagementWithClasses.PokeProgram.MakePokemon();
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
