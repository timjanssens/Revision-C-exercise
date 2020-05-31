using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class Rectangle
    {
        private double width = 1.0;

        public double Width 
        {
            get { return width ; }
            set { 
                if (value > 0)
                width = value;
                else
                    Console.WriteLine($"A value of {value} is not allowed for the width.");
            }
        }

        private double height = 1.0;

        public double Height
        {
            get { return height; }
            set { 
                if (value <= 0 )
                    Console.WriteLine($"It is not allowed to have {value} as a value for the height.");
                else
                height = value; 
            }
        }


        private double surface;

        public double Surface
        {
            get { return Width * Height; }
        }

       

    }
}
