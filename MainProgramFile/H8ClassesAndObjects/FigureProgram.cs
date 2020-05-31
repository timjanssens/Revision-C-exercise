using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class FigureProgram
    {
        public static void Main()
        {
            Console.Clear();
            var rectangleOne = new Rectangle(){ Height = 0, Width = 0};
            var rectangleTwo = new Rectangle(){ Height = 6, Width = 5};

            Console.WriteLine($"The rectangle with a width of {rectangleOne.Width} and a heigth of {rectangleOne.Height} has a surface of {rectangleOne.Surface} m\u00b2.");
            Console.WriteLine($"The rectangle with a width of {rectangleTwo.Width} and a heigth of {rectangleTwo.Height} has a surface of {rectangleTwo.Surface} m\u00b2.");

            Console.ReadKey();
        }
    }
}
