using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class CarsColection
    {
        public CarsColection()
        {
            Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }
    }
}
