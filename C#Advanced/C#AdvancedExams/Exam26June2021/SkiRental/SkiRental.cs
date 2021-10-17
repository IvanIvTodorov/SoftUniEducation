using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;
        public SkiRental(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => data.Count; }

        public void Add(Ski ski)
        {
            if (data.Count < Capacity)
            {
                data.Add(ski);
            }          
        }

        public bool Remove(string manufacturer, string model)
        {
            bool flag = false;
            if (data.Any(n => n.Manufacturer == manufacturer && n.Model == model))
            {
                Ski ski = data.First(n => n.Manufacturer == manufacturer && n.Model == model);
                data.Remove(ski);
                flag = true;
            }

            return flag;
        }

        public Ski GetNewestSki()
        {
            Ski ski = null;

            if (data.Count != 0)
            {
                ski = data.OrderByDescending(n => n.Year).First();
            }

            return ski;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            Ski ski = null;

            if (data.Count != 0 && data.Any(n => n.Manufacturer == manufacturer && n.Model == model))
            {
                ski = data.First(n => n.Manufacturer == manufacturer && n.Model == model);
            }

            return ski;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var ski in data)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
