using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    interface ICar
    {
        public string Model();
        public string Color();
        public string Start();
        public string Stop();
    }
}
