using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RawData
{
    public class CarColection
    {
        public CarColection()
        {
            Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }

        public void FragileOrFlamable(string condition, List<Car> cars)
        {
            if (condition == "fragile")
            {
                foreach (var item in this.Cars.Where(n => n.Tires.Any(p => p.Pressure < 1) && n.Cargo.Type == "fragile"))
                {
                    Console.WriteLine(item.Model);
                };
            }
            else
            {
                foreach (var item in this.Cars.Where(n => n.Engine.Power > 250 && n.Cargo.Type == "flammable"))
                {
                    Console.WriteLine(item.Model);
                };
            }

        }
    }
}
