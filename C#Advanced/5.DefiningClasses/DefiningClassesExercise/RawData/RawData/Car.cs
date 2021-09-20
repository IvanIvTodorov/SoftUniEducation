using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Tire[] tires;

        public Car(string model, Engine engine, Cargo cargo, Tire firstTire, Tire secondTire, Tire thirdTire, Tire forthTire)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = new Tire[] 
            { 
                firstTire,
                secondTire,
                thirdTire,
                forthTire           
            };
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Tire[] Tires
        {
            get { return tires; }
            set
            {
                if (value.Length == 4)
                {
                    tires = value;
                }
            }
        }
    }
}
