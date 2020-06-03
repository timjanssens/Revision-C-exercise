using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

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
                if (value > maxHp)
                    hP = maxHp;
                else if (value < 0)
                    hP = 0;
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
                    Console.WriteLine($"{this.PokeSpecie} ATTACKS");
                    Console.ResetColor();
                    break;
                case PokeTypes.Fire:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{this.PokeSpecie} ATTACKS");
                    Console.ResetColor();
                    break;
                case PokeTypes.Water:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{this.PokeSpecie} ATTACKS");
                    Console.ResetColor();
                    break;
                case PokeTypes.Electric:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{this.PokeSpecie} ATTACKS");
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }

        public void RestoreHP(int NewHp)
        {
            this.HP = NewHp;
        }

        public static void FightOutcome(Random random, Pokemon poke1, Pokemon poke2)
        {
            //helpvariable to decide who starts
            int player = random.Next(0, 2);

            bool keepPlaying = true;

            if ((poke1.HP == 0 ||poke1 == null) && (poke2.HP > 0 || poke2 == null))
                Console.WriteLine($"{poke2.PokeSpecie} {FightOutcomes.WIN}");
            else if ((poke1.HP > 0 || poke1 == null) && (poke2.HP == 0 || poke2 == null))
                Console.WriteLine($"{poke1.PokeSpecie} {FightOutcomes.WIN}");
            else if ((poke1.HP == 0 || poke1 == null) && (poke2.HP == 0 || poke2 == null))
                Console.WriteLine($"{ FightOutcomes.UNDECIDED}");
            else
            {

                while (keepPlaying)
                {
                    //switch player
                    player = (player + 1) % 2;


                    if (player == 0) //poke1 attacks
                    {
                        int attackPoints = random.Next(0, 21);
                        poke1.Attack();
                        Console.WriteLine(attackPoints);
                        int oldHP = poke2.HP;
                        poke2.HP -= attackPoints;
                        Console.WriteLine($"{poke2.PokeSpecie} had {oldHP}, after the attack he still has {poke2.HP}HP left");
                        if (poke2.HP == 0)
                        {
                            keepPlaying = false;
                            Console.WriteLine($"{poke1.PokeSpecie} {FightOutcomes.WIN}");
                        }
                    }
                    else if (player == 1) //poke2 attacks
                    {
                        int attackPoints = random.Next(0, 21);
                        poke2.Attack();
                        Console.WriteLine(attackPoints);
                        int oldHP = poke1.HP;
                        poke1.HP -= attackPoints;
                        Console.WriteLine($"{poke1.PokeSpecie} had {oldHP}, after the attack he still has {poke1.HP}HP left");
                        if (poke1.HP == 0)
                        {
                            keepPlaying = false;
                            Console.WriteLine($"{poke2.PokeSpecie} {FightOutcomes.WIN}");
                        }
                    }
                }
            }
            Console.ReadKey();

        }


    }
}
