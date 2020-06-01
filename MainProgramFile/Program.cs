using MainProgramFile.H8KlassenEnObjecten;
using MainProgramFile.H9MemoryManagementWithClasses;
using System;
using System.Xml.Serialization;

namespace MainProgramFile
{
    class Program
    {
        public static void Main(string[] args)
        {
            char choiceMain = '\0';

            while (choiceMain != 'q')
            {
                Console.Clear();
                Console.WriteLine("*************");
                Console.WriteLine("Main Program:");
                Console.WriteLine("*************");
                Console.WriteLine("1. H8 Classes and objewcts (+  DateTime)");
                Console.WriteLine("2. H9 Memory management with classes");
                Console.WriteLine("q. End program");

                choiceMain = Console.ReadKey().KeyChar;

                switch (choiceMain)
                {
                    case '1':
                        SubMenuH8.SubMenuH8Overview();
                        break;
                    case '2':
                        SubMenuH9.Main();
                        break;
                        


                    case 'q':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }


            }




            Console.ReadKey();
        }
    }

}
