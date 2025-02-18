using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>{

            new Square("red", 6),
            new Rectangle("blue", 3, 7),
            new Circle("green", 3),

        };

        foreach (Shape shape in shapes){

            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}