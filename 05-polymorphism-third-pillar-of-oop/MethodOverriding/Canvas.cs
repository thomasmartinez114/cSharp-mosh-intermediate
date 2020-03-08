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
                        Console.WriteLine("Now draw a circle.");
                        break;

                    case ShapeType.Rectangle:
                        Console.WriteLine("Now draw a rectangle.");
                        break; ;
                }
            }
        }
    }
}
