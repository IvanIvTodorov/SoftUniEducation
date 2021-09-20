using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";
        }
        public Engine(string model, string power, string displacement)
            : this(model, power)
        {
            Displacement = displacement;
            Efficiency = "n/a";
        }
        public Engine(string model,string power, string displacement, string efficiency)
            :this(model, power, displacement)
        {
            Efficiency = efficiency;
        }
        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"  {this.Model}:");
            sb.AppendLine($"    Power: {this.Power}");
            sb.AppendLine($"    Displacement: {this.Displacement}");
            sb.Append($"    Efficiency: {this.Efficiency}");

            return sb.ToString();
        }

    }
}
