using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Rectangle : Shape, IRectangle
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double Height { get; private set; }

        public double Width { get; private set; }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return (2 * Height) + (2 * Width);
        }

        public override string Draw()
        {
            return $"{base.Draw()} {this.GetType().Name}";
        }
    }
}
