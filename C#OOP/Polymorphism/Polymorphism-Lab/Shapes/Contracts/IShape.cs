using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public interface IShape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public  string Draw();
    }
}
