using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = "n/a";
            Color = "n/a";
        }
        public Car(string model, Engine engine, string weight)
            : this(model, engine)
        {
            Weight = weight;
            Color = "n/a";
        }
        public Car(string model, Engine engine, string weight, string color)
            : this(model,engine, weight)
        {
            Color = color;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.Model}:");
            str.AppendLine(this.Engine.ToString());
            str.AppendLine($"  Weight: {this.Weight}");
            str.AppendLine($"  Color: {this.Color}");

            return str.ToString().Trim();
        }
    }
}
