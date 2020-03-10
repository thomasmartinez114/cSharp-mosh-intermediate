using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        break;

                    case ShapeType.Rectangle:
                        Console.WriteLine("Now draw a rectangle");
                        break;

                    case ShapeType.Triangle:
                        Console.WriteLine("Now draw a triangle");
                        break;
                }
            }
        }
    }
}
