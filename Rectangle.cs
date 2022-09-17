using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area
        {
            get
            {
                Console.WriteLine("Get area");
                return Width * Height;
            }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
