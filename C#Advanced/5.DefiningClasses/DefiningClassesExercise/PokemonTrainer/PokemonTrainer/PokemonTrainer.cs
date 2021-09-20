using System;
using System.Linq;

namespace PokemonTrainer
{
    class PokemonTrainer
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = null;
            int index = 0;
            TrainersColection trainersColection = new TrainersColection();
            while (input != "Tournament")
            {
                values = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Pokemon pokemon = new Pokemon(values[1], values[2], int.Parse(values[3]));

                if (!trainersColection.Trainers.Any(n => n.Name == values[0]))
                {
                    Trainer trainer = new Trainer(values[0], pokemon);

                    trainersColection.Trainers.Add(trainer);
                }
                else
                {
                    index = trainersColection.Trainers.FindIndex(n => n.Name == values[0]);

                    trainersColection.Trainers[index].Pokemons.Add(pokemon);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();


            while (input != "End")
            {
                foreach (var trainer in trainersColection.Trainers)
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (trainer.Pokemons.Any(n => n.Element == input))
                        {
                            trainer.Badges++;
                            break;
                        }
                        else
                        {
                            pokemon.Health -= 10;
                        }
                    }
                    if (trainer.Pokemons.Any(n => n.Health <= 0))
                    {
                        index = trainer.Pokemons.FindIndex(n => n.Health <= 0);

                        trainer.Pokemons.RemoveAt(index);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, trainersColection.Trainers.OrderByDescending(n => n.Badges)));
        }
    }
}
