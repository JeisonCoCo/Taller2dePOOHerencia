﻿using ConsoleApp1;
using Geometry;
using System.Drawing;
using Rectangle = ConsoleApp1.Rectangle;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var circle = new Circle(nameof(Circle), 5);
            var square = new Square(nameof(Square), 10);
            var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
            var kite = new Kite(nameof(Kite), 7, 6, 5, 8);
            var rectangle = new Rectangle(nameof(nameof(Rectangle)), 4.568, 67.790);
            var parallelogram = new Parallelogram(nameof(Parallelogram), 14.65, 54.67, 23.09);
            var triangle = new Triangle(nameof(Triangle), 45.56, 12.34, 27.09);
            var trapeze = new Trapeze(nameof(Trapeze), 10, 20, 30, 40, 20);

            var figures = new List<GeometricFigure>(){
                    circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze
            };

            foreach (var figure in figures)
            {
                       Console.WriteLine(figure);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


