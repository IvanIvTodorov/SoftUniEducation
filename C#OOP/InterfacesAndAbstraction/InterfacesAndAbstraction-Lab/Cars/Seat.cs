using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model,string color)
        {
            this.model = model;
            this.color = color;
        }

        public string Color()
        {
            return this.color;
        }

        public string Model()
        {
            return this.model;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{color} {this.GetType().Name} {model}");
            sb.AppendLine($"{Start()}");
            sb.AppendLine($"{Stop()}");

            return sb.ToString().Trim();
        }
    }
}
