﻿using Mentoring.DataModel;
using Mentoring.Shapes.Interfaces;
using Mentoring.Shapes.Shapes;
using Xunit;

namespace Module1.TypesAndClasses.Tests.Shapes
{
    public class RectangleTest
    {
        [Theory]
        [InlineData(10.0, 20.0, 200.0)]
        [InlineData(5.0, 20.0, 100.0)]
        public void TestSquare(double a, double b, double expectedSquare)
        {           
            var rect = new Rectangle(a, b, Units.Meter);
            Assert.Equal(expectedSquare, rect.GetSquare());
        }

        [Theory]
        [InlineData(2.0, 2.0, Units.Meter, 4.0)]
        [InlineData(2.0, 2.0, Units.Centimeter, 4.0)]
        [InlineData(2.0, 2.0, Units.Millimeter, 4.0)]
        public void TestSquareWithUnits(double a, double b, Units unit, double expectedSquare)
        {         
            var rect = new Rectangle(a, b, unit);
            Assert.Equal(unit, rect.Unit);
            Assert.Equal(expectedSquare, rect.GetSquare());            
        }

        [Theory]
        [InlineData(2.0, 2.0, Units.Meter, 4.0)]
        [InlineData(2.0, 2.0, Units.Centimeter, 4.0)]
        [InlineData(2.0, 2.0, Units.Millimeter, 4.0)]
        public void TestPerimeterWithUnits(double a, double b, Units unit, double expectedPerimeter)
        {
            var rect = new Rectangle(a, b, unit);
            Assert.Equal(unit, rect.Unit);
            Assert.Equal(expectedPerimeter, rect.GetPerimeter());
        }
    }
}
