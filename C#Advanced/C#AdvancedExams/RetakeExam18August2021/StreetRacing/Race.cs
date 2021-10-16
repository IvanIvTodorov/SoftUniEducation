using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name,string type,int laps,int capacity,int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }

        public List<Car> Participants { get; set; }
        public string Name { get; set; }
        public string  Type { get; set; }
        public int Laps { get; set; }
        public int  Capacity { get; set; }
        public int MaxHorsePower  { get; set; }
        public int Count { get => Participants.Count; }

        public void Add(Car car)
        {
            if (Count <= Capacity)
            {
                if (Participants.Any(n => n.LicensePlate == car.LicensePlate) == false)
                {
                    if (car.HorsePower <= MaxHorsePower)
                    {
                        Participants.Add(car);
                    }
                }
            }
            
        }
        public bool Remove(string licensePlate)
        {
            bool flag = false;

            if (Participants.Any(n => n.LicensePlate == licensePlate) == true)
            {
                Car car = Participants.First(n => n.LicensePlate == licensePlate);
                Participants.Remove(car);
                flag = true;
            }
            return flag;
        }

        public Car FindParticipant(string licensePlate)
        {
            if (Participants.Any(n => n.LicensePlate == licensePlate) == true)
            {
                Car car = Participants.First(n => n.LicensePlate == licensePlate);
                return car;
            }
            return null;
        }

        public Car GetMostPowerfulCar()
        {
            if (Count == 0)
            {
                return null;
            }
            Car car = Participants.OrderByDescending(n => n.HorsePower).First();
            return car;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var car in Participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
