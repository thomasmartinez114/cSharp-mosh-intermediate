﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Circle : Shape
    {

    }

    public class Rectangle : Shape
    {

    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
    }
}
