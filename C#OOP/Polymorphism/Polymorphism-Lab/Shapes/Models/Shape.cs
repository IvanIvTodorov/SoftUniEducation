using Shapes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public virtual string Draw()
        {
            return "Drawing";
        }
    }
}
