using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class TrainersColection
    {
        public TrainersColection()
        {
            Trainers = new List<Trainer>();
        }
        public List<Trainer> Trainers { get; set; }
    }
}
