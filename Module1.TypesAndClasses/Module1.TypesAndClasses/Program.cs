﻿using Module1.TypesAndClasses.Extensions;
using Module1.TypesAndClasses.Generics;
using Module1.TypesAndClasses.Helpers;
using Module1.TypesAndClasses.Interfaces;
using Module1.TypesAndClasses.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Module1.TypesAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Module 1. Shapes example.");

            var shapes = new List<IShape>
            {
                //new Ellipse(2,3),
                new Circle(1, Units.centimeters),
                //new Rectangle(1,1),
                new EquilateralTriangle(5, Units.meters),
                //new RegularPolygon()
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }

            //Console.WriteLine("Testing ShapeHelper");
            //Console.WriteLine(ShapeHelper.PerimeterEquals(new EquilateralTriangle(5), new Circle(2)));
            //Console.WriteLine(ShapeHelper.SquareEquals(new EquilateralTriangle(5), new Circle(2)));

            //Console.WriteLine("Testing ShapeExtensions");
            //var triangle = new EquilateralTriangle(7);
            //Console.WriteLine(triangle.PerimeterEquals(new EquilateralTriangle(7)));
            //Console.WriteLine(triangle.SquareEquals(new Rectangle(2, 3)));

            //Console.WriteLine("Test Generics");
            //var b = ShapePrinter.Print();

            var triangle = new EquilateralTriangle(5, Units.centimeters);
            var triangle2 = new EquilateralTriangle(0.05, Units.meters);
            Console.WriteLine($"Perimeter 1 = {triangle.Perimeter()} cm");
            Console.WriteLine($"Perimeter 2 = {triangle2.Perimeter()} m");
            Console.WriteLine($"Square 1 = {triangle.Square()} cm");
            Console.WriteLine($"Square 2 = {triangle2.Square()} m");
            Console.WriteLine($"Perimeters equal? {triangle.PerimeterEquals(triangle, triangle2)}");
            Console.WriteLine($"Squares equal? {triangle.SquareEquals(triangle, triangle2)}");

            var circle1 = new Circle(5, Units.centimeters);
            var circle2 = new Circle(0.05, Units.meters);
            Console.WriteLine($"Perimeter 1 = {circle1.Perimeter()} cm");
            Console.WriteLine($"Perimeter 2 = {circle2.Perimeter()} m");
            Console.WriteLine($"Square 1 = {circle1.Square()} cm");
            Console.WriteLine($"Square 2 = {circle2.Square()} m");
            Console.WriteLine($"Perimeters equal? {circle1.PerimeterEquals(circle1, circle2)}");
            Console.WriteLine($"Squares equal? {circle1.SquareEquals(circle1, circle2)}");
            Console.WriteLine($"Perimeters equal? {circle1.PerimeterEquals(circle1, circle2)}");
            Console.WriteLine($"Squares equal? {circle1.SquareEquals(circle1, circle2)}");

            #region For Testing Linq
            Console.WriteLine("Module 3. Shapes Linq example.");
            var shapes2 = new List<IShape>
            {
                new Circle(2,Units.meters),
                new EquilateralTriangle(5),
                new Rectangle(4,4, Units.meters),
                new Rectangle(40,50, Units.centimeters),
                new Rectangle(600,400, Units.centimeters),
                new Rectangle(400,200, Units.centimeters),
                new Rectangle(4000,8000, Units.millimeters)
            };
            // IEnumerable<IShape> Fileterdshape = shapes.Where(shape => shape.Units == Units.meters);
            foreach (var shape in shapes2)
            {
                Console.WriteLine($"Shape:{shape}");
            }
            var ShapePerimeter = shapes2.Single(shape => shape.Perimeter() == 12);
            Console.WriteLine($"Shape with Perimeter = 12:{ShapePerimeter.ShapeName}, Perimeter: {ShapePerimeter.Perimeter()} {Units.meters}");
            var ShapeSquareCircle = shapes2.Where(shape => (shape.Square() > 1 && shape.ShapeName == "Circle")).OrderByDescending(shape => shape.Square()).First();
            Console.WriteLine($"Shape with Square:{ShapeSquareCircle.Square()} m2, Perimeter: {ShapeSquareCircle}");
            var ShapePerimeterRectangle = shapes2.Where(shape => shape.ShapeName == "Rectangle").OrderBy(shape => shape.Perimeter()).FirstOrDefault();
            var ShapePerimeterRectangle2 = shapes2.OfType<Rectangle>().OrderBy(shape => shape.Perimeter()).FirstOrDefault();
            Console.WriteLine($"ShapePerimeterRectangle Shape with Perimeter:{ShapePerimeterRectangle.Perimeter()} m, {ShapePerimeterRectangle}");
            Console.WriteLine($"ShapePerimeterRectangle2 Shape with Perimeter:{ShapePerimeterRectangle2.Perimeter()} m, {ShapePerimeterRectangle2}");
            List<IShape> ShapeRectangleandCircle = shapes2.Where(shape => shape.ShapeName == "Rectangle" || shape.ShapeName == "Circle").ToList();
            Console.WriteLine($"{ShapeRectangleandCircle.Count()} and the First List is {ShapeRectangleandCircle[0]} ");

            // var ShapeRectangleandCircle2 = shapes2.Where(shape => shape.ShapeName == "Rectangle" || shape.ShapeName == "Circle");
            // Console.WriteLine($"{ShapeRectangleandCircle2.Count()} and the First List is {ShapeRectangleandCircle2.First()} ");
            List < List < IShape >> ShapeList = new List<List<IShape>> { ShapeRectangleandCircle, shapes };
            var PerimeterList = shapes.Select(shape => shape.Perimeter()).OrderBy(shape => shape).ToList();

          //  var PerimeterList2 = ShapeList.SelectMany(shape => shape).OrderBy(shape => shape).ToList();
            //    Select(shape => shape.Perimeter()).OrderBy(shape => shape).ToList();
            foreach (var shape in PerimeterList)
            {           Console.WriteLine($"Shape:{shape}");            }
            #endregion
        }
    }
}
