using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ListUnion.Tests
{
    public class LoopTesting
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 5 })]
        public void FindLast_lastIndexFound(int[] x)
        {
            // Arrange
            int expected = 0;

            // Act
            int actual = ListUnion.LoopTesting.FindLast(x, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 0 })]
        public void LastZero_lastZeroFound(int[] x)
        {
            // Arrange
            int expected = 2;

            // Act
            int actual = ListUnion.LoopTesting.LastZero(x);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -4, 2, 0, 2 })]
        public void CountPositive_correctCountReturned(int[] x)
        {
            // Arrange
            int expected = 2;

            // Act
            int actual = ListUnion.LoopTesting.CountPositive(x);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -3, -2, 0, 1, 4 })]
        public void findLast_lastIndexFound(int[] x)
        {
            // Arrange
            int expected = 3;

            // Act
            int actual = ListUnion.LoopTesting.OddOrPos(x);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
