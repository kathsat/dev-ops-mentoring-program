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
                new Ellipse(2,3),
                new Circle(1, Units.centimeters),
                new Rectangle(1,1,Units.meters),
                new EquilateralTriangle(5, Units.meters),
                //new RegularPolygon()
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }

            //var triangle = new EquilateralTriangle(5, Units.centimeters);
            //var triangle2 = new EquilateralTriangle(0.05, Units.meters);
            //Console.WriteLine($"Perimeter 1 = {triangle.Perimeter()} cm");
            //Console.WriteLine($"Perimeter 2 = {triangle2.Perimeter()} m");
            //Console.WriteLine($"Square 1 = {triangle.Square()} cm");
            //Console.WriteLine($"Square 2 = {triangle2.Square()} m");
            //Console.WriteLine($"Perimeters equal? {triangle.PerimeterEquals(triangle, triangle2)}");
            //Console.WriteLine($"Squares equal? {triangle.SquareEquals(triangle, triangle2)}");

            //var circle1 = new Circle(5, Units.centimeters);
            //var circle2 = new Circle(0.05, Units.meters);
            //Console.WriteLine($"Perimeter 1 = {circle1.Perimeter()} cm");
            //Console.WriteLine($"Perimeter 2 = {circle2.Perimeter()} m");
            //Console.WriteLine($"Square 1 = {circle1.Square()} cm");
            //Console.WriteLine($"Square 2 = {circle2.Square()} m");
            //Console.WriteLine($"Perimeters equal? {circle1.PerimeterEquals(circle1, circle2)}");
            //Console.WriteLine($"Squares equal? {circle1.SquareEquals(circle1, circle2)}");
            //Console.WriteLine($"Perimeters equal? {circle1.PerimeterEquals(circle1, circle2)}");
            //Console.WriteLine($"Squares equal? {circle1.SquareEquals(circle1, circle2)}");

            #region Kate task 3 - will remove soon

            EquilateralTriangle triangle = new EquilateralTriangle(3, Units.centimeters);
            EquilateralTriangle triangle2 = new EquilateralTriangle(7.8, Units.millimeters);
            EquilateralTriangle triangle3 = new EquilateralTriangle(5, Units.meters);
            Circle circle = new Circle(5, Units.meters);
            Circle circle2 = new Circle(2.6, Units.centimeters);
            Circle circle3 = new Circle(8, Units.millimeters);
            Ellipse ellipse = new Ellipse(4, 6, Units.millimeters);
            Ellipse ellipse2 = new Ellipse(6, 9, Units.centimeters);
            Ellipse ellipse3 = new Ellipse(1, 2, Units.meters);
            Rectangle rectangle = new Rectangle(5, 8, Units.centimeters);
            Rectangle rectangle2 = new Rectangle(10, 24, Units.millimeters);
            Rectangle rectangle3 = new Rectangle(2, 3, Units.meters);

            Console.WriteLine($"triangle: perimeter = {triangle.Perimeter()} {triangle.Units}, square = {triangle.Square()} {triangle.Units}");
            Console.WriteLine($"triangle2: perimeter = {triangle2.Perimeter()} {triangle2.Units}, square = {triangle2.Square()} {triangle2.Units}");
            Console.WriteLine($"triangle3: perimeter = {triangle3.Perimeter()} {triangle3.Units}, square = {triangle3.Square()} {triangle.Units}");
            Console.WriteLine($"circle: perimeter = {circle.Perimeter()} {circle.Units}, square = {circle.Square()} {circle.Units}");
            Console.WriteLine($"circle2: perimeter = {circle2.Perimeter()} {circle2.Units}, square = {circle2.Square()} {circle2.Units}");
            Console.WriteLine($"circle3: perimeter = {circle3.Perimeter()} {circle3.Units}, square = {circle3.Square()} {circle3.Units}");
            Console.WriteLine($"ellipse: perimeter = {ellipse.Perimeter()} millimeters, square = {ellipse.Square()} millimeters");
            Console.WriteLine($"ellipse2: perimeter = {ellipse2.Perimeter()} centimeters, square = {ellipse2.Square()} centimeters");
            Console.WriteLine($"ellipse3: perimeter = {ellipse3.Perimeter()} meters, square = {ellipse3.Square()} meters");
            Console.WriteLine($"rectangle: perimeter = {rectangle.Perimeter()} {rectangle.Units}, square = {rectangle.Square()} {rectangle.Units}");
            Console.WriteLine($"rectangle2: perimeter = {rectangle2.Perimeter()} {rectangle2.Units}, square = {rectangle2.Square()} {rectangle2.Units}");
            Console.WriteLine($"rectangle3: perimeter = {rectangle3.Perimeter()} {rectangle3.Units}, square = {rectangle3.Square()} {rectangle3.Units}");

            var KateShapes = new List<IShape> {
                new EquilateralTriangle(3, Units.centimeters),
                new EquilateralTriangle(7.8, Units.millimeters),
                new EquilateralTriangle(5, Units.meters),
                new Circle(5, Units.meters),
                new Circle(8, Units.millimeters),
                new Circle(2.6, Units.centimeters),
                new Ellipse(4, 6, Units.millimeters),
                new Ellipse(6, 9, Units.centimeters),
                new Ellipse(1, 2, Units.meters),
                new Rectangle(5, 8, Units.centimeters),
                new Rectangle(10, 24, Units.millimeters),
                new Rectangle(1, 2, Units.meters)
            };

            //var rc = shapes.Where(s => s.GetType().Name == "Rectangle" || s.GetType().Name == "Circle").ToList();
            //foreach (var i in rc) {
            //    Console.WriteLine(i);
            //}

            var squares = KateShapes.Select(s => s.Square()).OrderBy(s => s);
            foreach (var i in squares)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(squares.Max());
            Console.WriteLine(squares.Min());

            #endregion
        }
    }
}
