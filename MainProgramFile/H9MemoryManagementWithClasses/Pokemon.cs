using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H9MemoryManagementWithClasses
{
    class Pokemon
    {
        #region Properties

        private int maxHp;
        public int MaxHp
        {
            get { return maxHp; }
            set
            {
                if (value < 20)
                    maxHp = 20;
                else if (value > 1000)
                    maxHp = 1000;
                else
                    maxHp = value;
            }
        }

        private int hP;

        public int HP
        {
            get { return hP; }
            set
            {
                if (hP < 0)
                    hP = 0;
                else if (hP > MaxHp)
                    hP = MaxHp;
                else
                    hP = value;
            }
        }
        
        public PokeSpecies PokeSpecie { get; set; }

        public PokeTypes PokeType { get; set; }

        #endregion

        public void Attack()
        {
            switch (PokeType)
            {
                case PokeTypes.Grass:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(this.PokeSpecie);
                    Console.ResetColor();
                    break;
                case PokeTypes.Fire:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(this.PokeSpecie);
                    Console.ResetColor();
                    break;
                case PokeTypes.Water:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(this.PokeSpecie);
                    Console.ResetColor();
                    break;
                case PokeTypes.Electric:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(this.PokeSpecie);
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }



    }
}
