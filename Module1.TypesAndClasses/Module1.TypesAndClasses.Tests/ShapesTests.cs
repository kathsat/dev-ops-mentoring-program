using Module1.TypesAndClasses.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Module1.TypesAndClasses.Tests
{
    public class ShapesTests : IDisposable
    {
        #region private fields

        private readonly Mock<IShape> _circle;
        private readonly Mock<IShape> _ellipse;
        private readonly Mock<IShape> _equilateralTriangle;
        private readonly Mock<IShape> _rectangle;
        private readonly Mock<IShape> _regularPolygon;

        #endregion

        #region constructor, disposing

        public ShapesTests()
        {
            _circle = new Mock<IShape>();
            _regularPolygon = new Mock<IShape>();
            _equilateralTriangle = new Mock<IShape>();

            // todo: remove after the methods are implemented
            _circle.Setup(c => c.Perimeter()).Returns(10);
            _circle.Setup(c => c.Square()).Returns(200);

            _regularPolygon.Setup(c => c.Perimeter()).Returns(86);
            _regularPolygon.Setup(c => c.Square()).Returns(100);

            _equilateralTriangle.Setup(c => c.Perimeter()).Returns(10);
            _equilateralTriangle.Setup(c => c.Square()).Returns(100);
        }

        public void Dispose()
        {
            _circle.Reset();
        }

        #endregion

        [Fact]
        public void TestShapesToString()
        {
            var shapes = new List<IShape>
            {
                _circle.Object,
                // todo: add all other shapes
            };

            foreach (var shape in shapes)
            {
                Assert.Equal($"Shape: '{shape.GetType().Name}'. Square = {shape.Square()}, perimeter = {shape.Perimeter()}", shape.ToString());
            }
        }

        [Fact]
        public void TestShapesEquals()
        {
            // Equals - by perimeter
            Assert.True(_circle.Object.Equals(_equilateralTriangle.Object));
            Assert.False(_circle.Object.Equals(_regularPolygon.Object));
            Assert.False(_regularPolygon.Object.Equals(_equilateralTriangle.Object));

            // == - by square            
            Assert.True(_regularPolygon.Object == _equilateralTriangle.Object);
            Assert.False(_circle.Object == _equilateralTriangle.Object);
            Assert.False(_circle.Object == _regularPolygon.Object);
        }
    }
}
