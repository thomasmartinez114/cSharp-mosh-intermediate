﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // Any code specific to the cirlce itself
            Console.WriteLine("Now draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Now draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}
