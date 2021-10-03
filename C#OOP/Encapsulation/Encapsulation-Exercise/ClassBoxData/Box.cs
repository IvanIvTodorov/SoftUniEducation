using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {

        private double length;

        private double height;

        private double width;

        public Box(double length, double width, double height)
        {
            Length = length;           
            Width = width;
            Height = height;
        }
        private double Width
        {
            get { return width; }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;        
            }
        }

        private double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value; 
            }
        }

        private double Length
        {
            get { return length; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }

                length = value;
            }
        }


        public void SurfaceArea()
        {

            double surfaceArea = (2 * this.length * this.height) + (2 * this.length * this.width) + (2 * this.width * this.height);

            Console.WriteLine($"Surface Area - {surfaceArea:F2}");
        }

        public void LateralSurfaceArea()
        {

            double lateralSurfaceArea = (2 * this.length * this.height) + (2 * this.width * this.height);

            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");
        }

        public void Volume()
        {
            double volume = length * width * height;

            Console.WriteLine($"Volume - {volume:F2}");
        }
    }
}
