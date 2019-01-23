using System.Drawing;
using Xunit;

namespace ListUnion.Tests
{
    public class CastTesting
    {
        [Fact]
        public void Clone_TruckComparisonEvaluates()
        {
            // Arrange
            Truck suv = new Truck(4);
            Truck co = (Truck)suv.Clone();
            bool[] expected = { true, true };

            // Act
            bool[] actual = new bool[] { (suv.x == co.x), (suv.GetType() == co.GetType()) };

            // Assert
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void Equals_PointEqualsColorPoint()
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
        public void Equals_ColorPointEqualsPoint()
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
        public void Equals_ColorPointDoesNotEqualDifferentColorPoint()
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



        [Fact]
        public void Equals_DecimalsEquate()
        {
            // Arrange
            BigDecimalTest BDT = new BigDecimalTest();
            bool expected = true;

            // Act
            bool actual = BDT.x.Equals(BDT.y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CompareTo_DecimalsDontEquate()
        {
            // Arrange
            BigDecimalTest BDT = new BigDecimalTest();
            int expected = 0;

            // Act
            int actual = BDT.x.CompareTo(BDT.y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
