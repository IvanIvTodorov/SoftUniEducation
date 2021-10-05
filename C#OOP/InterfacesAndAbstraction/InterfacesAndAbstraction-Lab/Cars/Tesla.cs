using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;

        public Tesla(string model,string color,int battery)
        {
            this.model = model;
            this.color = color;
            this.battery = battery;
        }
        public int Battery()
        {
            return battery;
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
            sb.AppendLine($"{color} {this.GetType().Name} {model} with {Battery()} Batteries");
            sb.AppendLine($"{Start()}");
            sb.AppendLine($"{Stop()}");

            return sb.ToString().Trim();
        }
    }
}
