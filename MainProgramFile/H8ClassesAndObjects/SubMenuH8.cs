using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class SubMenuH8
    {
        public static void SubMenuH8Overview()
        {

            bool keepMenu = true;

            while (keepMenu)
            {


                Console.Clear();
                Console.WriteLine("*******************************");
                Console.WriteLine("SubMenu H8 Klassen en objecten:");
                Console.WriteLine("*******************************");
                Console.WriteLine("1. Clock");
                Console.WriteLine("2. Days till birthday");
                Console.WriteLine("3. Days of the week");
                Console.WriteLine("4. Simpele timing");
                Console.WriteLine("5. Report module V1");
                Console.WriteLine("6. Report module V2");
                Console.WriteLine("7. Number combination");
                Console.WriteLine("8. Figures");
                Console.WriteLine("9. Student class");


                Console.WriteLine("r. Return to main menu");
                Console.WriteLine("q. Quit program");

                char choiceSub = Console.ReadKey().KeyChar;

                switch (choiceSub)
                {
                    case '1':
                        Klokje.Main();
                        break;
                    case '2':
                        Verjaardag.Main();
                        break;
                    case '3':
                        DayOfWeekProgram.Main();
                        break;
                    case '4':
                        ArrayTimerProgram.Main();
                        break;
                    case '5':
                        ResultV1.Main();
                        break;
                    case '6':
                        ResultV2.Main();
                        break;
                    case '7':
                        NumberCombination.Main();
                        break;
                    case '8':
                        FigureProgram.Main();
                        break;
                    case '9':
                        Student.Main();
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
