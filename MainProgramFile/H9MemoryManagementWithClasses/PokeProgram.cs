using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Authentication.ExtendedProtection;
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

        public static Pokemon FirstCosiousPokemon(Pokemon[] pokemons)
        {
            for (int i = 0; i < pokemons.Length; i++)
            {
                if (pokemons[i].HP > 0)
                    return pokemons[i];
            }
            return null;
        }

        public static void TestConsiousPokemon()
        {
            Console.Clear();

            //make 4 pokemon
            var poke1 = new Pokemon() { HP = 20, MaxHp = 20, PokeSpecie = PokeSpecies.Balbasaur, PokeType = PokeTypes.Grass };
            var poke2 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Charmander, PokeType = PokeTypes.Fire };
            var poke3 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Squirtle, PokeType = PokeTypes.Water };
            var poke4 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Pickachu, PokeType = PokeTypes.Electric };

            //put the 4 new pokemon in an Array
            Pokemon[] pokemons = { poke1, poke2, poke3, poke4 };

            //make new pokemon and run the method and make the firstconsiouspokemon in the pokemon
            Pokemon firstConsiousPokemon = FirstCosiousPokemon(pokemons);

            firstConsiousPokemon.Attack();

            Console.ReadKey();

        }

        public static void testConsiousPokemonSafe()
        {
            Console.Clear();

            //make 4 pokemon
            var poke1 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Balbasaur, PokeType = PokeTypes.Grass };
            var poke2 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Charmander, PokeType = PokeTypes.Fire };
            var poke3 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Squirtle, PokeType = PokeTypes.Water };
            var poke4 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Pickachu, PokeType = PokeTypes.Electric };

            //put the 4 new pokemon in an Array
            Pokemon[] pokemons = { poke1, poke2, poke3, poke4 };

            //make new pokemon and run the method and make the firstconsiouspokemon in the pokemon
            Pokemon firstConsiousPokemon = FirstCosiousPokemon(pokemons);

            if (firstConsiousPokemon != null)
                firstConsiousPokemon.Attack();
            else
                Console.WriteLine("All of your pokemon are KO! Hurry to the Pokemon Center");

            Console.ReadKey();
        }



        public static void DemoRestoreHP()
        {
            Console.Clear();

            //make 4 pokemon
            var poke1 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Balbasaur, PokeType = PokeTypes.Grass };
            var poke2 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Charmander, PokeType = PokeTypes.Fire };
            var poke3 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Squirtle, PokeType = PokeTypes.Water };
            var poke4 = new Pokemon() { HP = 0, MaxHp = 20, PokeSpecie = PokeSpecies.Pickachu, PokeType = PokeTypes.Electric };

            //put the 4 new pokemon in an Array
            Pokemon[] pokemons = { poke1, poke2, poke3, poke4 };

           
            for (int i = 0; i < pokemons.Length; i++)
            {
                pokemons[i].RestoreHP(50);
            }

            for (int i = 0; i < pokemons.Length; i++)
            {
                Console.WriteLine(pokemons[i].HP);
            }


            Console.ReadKey();
        }


        public static void DemoFightOutcome()
        {
            Console.Clear();

            var balbasaur = new Pokemon(){ MaxHp = 20, HP = 20,  PokeSpecie = PokeSpecies.Balbasaur, PokeType = PokeTypes.Grass };
            var charmander = new Pokemon() { MaxHp = 20, HP = 0,  PokeSpecie = PokeSpecies.Charmander, PokeType = PokeTypes.Fire };
            var squirtle = new Pokemon() { MaxHp = 20, HP = 20,  PokeSpecie = PokeSpecies.Squirtle, PokeType = PokeTypes.Water };
            var pickachu = new Pokemon() { MaxHp = 20, HP = 20,  PokeSpecie = PokeSpecies.Pickachu, PokeType = PokeTypes.Electric };

            Random random = new Random();

            Pokemon.FightOutcome(random, balbasaur, charmander);

            Console.ReadKey();
          
        }

        public static void DemoUpgradeFightOutcome()
        {
            Console.Clear();

            var balbasaur = new Pokemon() { MaxHp = 20, HP = 20, PokeSpecie = PokeSpecies.Balbasaur, PokeType = PokeTypes.Grass };
            var charmander = new Pokemon() { MaxHp = 20, HP = 20, PokeSpecie = PokeSpecies.Charmander, PokeType = PokeTypes.Fire };
            var squirtle = new Pokemon() { MaxHp = 20, HP = 20, PokeSpecie = PokeSpecies.Squirtle, PokeType = PokeTypes.Water };
            var pickachu = new Pokemon() { MaxHp = 20, HP = 20, PokeSpecie = PokeSpecies.Pickachu, PokeType = PokeTypes.Electric };

            Pokemon[] pokemons = { balbasaur, charmander, squirtle,pickachu};

            Random random = new Random();

            Console.WriteLine("******************************");
            Console.WriteLine("*Welcome in the Pokemon Arena*");
            Console.WriteLine("******************************");
            Console.WriteLine("Which Pokemon do you choose as your own to fight with");
            int counter = 1;
            foreach (var poke in pokemons)
            {
                Console.WriteLine($"{counter++}. {poke.PokeSpecie}");
            }
            
            char choiceOwn = Console.ReadKey().KeyChar;
            var ownPokemon = new Pokemon();

            switch (choiceOwn)
            {
                case '1':
                    ownPokemon = balbasaur;
                    break;
                case '2':
                    ownPokemon = charmander;
                    break;
                case '3':
                    ownPokemon = squirtle;
                    break;
                case '4':
                    ownPokemon = pickachu;
                    break;

                default:
                    break;
            }

            Console.WriteLine($"\rGreat you choose {ownPokemon.PokeSpecie} as your Pokemon");

            Console.WriteLine("Which Pokemon do you choose as your own to fight with");
            counter = 1;
            foreach (var poke in pokemons)
            {
                if(ownPokemon.PokeSpecie != poke.PokeSpecie)
                {
                    Console.WriteLine($"{counter++}. {poke.PokeSpecie}");
                }
                else
                {
                    Console.WriteLine($"{counter++}. ----");
                }
            }

            char choiceOther = Console.ReadKey().KeyChar;
            var otherPokemon = new Pokemon();
            
            switch (choiceOther)
            {
                case '1':
                    otherPokemon = balbasaur;
                    break;
                case '2':
                    otherPokemon = charmander;
                    break;
                case '3':
                    otherPokemon = squirtle;
                    break;
                case '4':
                    otherPokemon = pickachu;
                    break;

                default:
                    break;
            }
            Console.WriteLine($"\r{ownPokemon.PokeSpecie} VS {otherPokemon.PokeSpecie}");

            Pokemon.FightOutcome(random, ownPokemon, otherPokemon);


            Console.ReadKey();
        }

    }
}
