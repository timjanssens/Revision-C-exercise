using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H9MemoryManagementWithClasses
{
    class PokeProgram
    {

        public static void MakePokemon()
        {
            Console.Clear();

            //make 4 new pokemon
            var poke1 = new Pokemon() { HP = 20, MaxHp = 20, PokeSpecie = PokeSpecies.Balbasaur, PokeType = PokeTypes.Grass };
            var poke2 = new Pokemon() { HP = 20, MaxHp = 20, PokeSpecie = PokeSpecies.Charmander, PokeType = PokeTypes.Fire };
            var poke3 = new Pokemon() { HP = 20, MaxHp = 20, PokeSpecie = PokeSpecies.Squirtle, PokeType = PokeTypes.Water };
            var poke4 = new Pokemon() { HP = 20, MaxHp = 20, PokeSpecie = PokeSpecies.Pickachu, PokeType = PokeTypes.Electric };

            //let the 4 pokemon attack
            poke1.Attack();
            poke2.Attack();
            poke3.Attack();
            poke4.Attack();


            Console.ReadKey();
        }

    }
}
