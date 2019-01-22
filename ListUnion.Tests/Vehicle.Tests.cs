using System.Drawing;
using Xunit;

namespace ListUnion.Tests
{
    public class Vehicle
    {
        [Fact]
        public void Vehicle_TruckComparisonEvaluates()
        {
            // Arrange
            Truck suv = new Truck(4);
            Truck co = suv.Clone();
            bool[] expected = { true, true };

            // Act
            bool[] actual = new bool[2];
            actual[0] = (suv.x == co.x);
            actual[1] = (suv.GetType() == co.GetType());

            // Assert
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void Vehicle_PointEqualsColorPoint()
        {
            // Arrange
            Point P = new Point(1, 2);
            ColorPoint cp1 = new ColorPoint(1, 2, Color.Red);
            bool expected = true;

            // Act
            bool actual = P.Equals(cp1);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Vehicle_ColorPointEqualsPoint()
        {
            // Arrange
            Point P = new Point(1, 2);
            ColorPoint cp1 = new ColorPoint(1, 2, Color.Red);
            bool expected = true;

            // Act
            bool actual = ((Point)cp1).Equals(P);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Vehicle_ColorPointDoesNotEqualDifferentColorPoint()
        {
            // Arrange
            ColorPoint cp1 = new ColorPoint(1, 2, Color.Red);
            ColorPoint cp2 = new ColorPoint(1, 2, Color.Blue);
            bool expected = false;

            // Act
            bool actual = cp1.Equals(cp2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
