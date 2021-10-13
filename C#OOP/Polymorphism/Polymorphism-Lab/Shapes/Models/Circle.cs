using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Circle : Shape, ICircle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; private set;}

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string Draw()
        {
            return $"{base.Draw()} {this.GetType().Name}";
        }
    }
}
