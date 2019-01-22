﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ListUnion.Tests
{
    public class UnionizerTests
    {
        List<string> TestList1 = new List<string>() {"joe", "mary"};
        List<string> TestList2 = new List<string>() {"mike", "justin"};
        List<string> ExpectedList = new List<string>() {"joe", "mary", "mike", "justin"};

        [Fact]
        public void Union_2ListsUnion()
        {
            // Arrange
            List<string> expected = ExpectedList;

            // Act
            List<string> actual = Unionizer.Union(TestList1, TestList2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Union_1stListBlank()
        {
            // Arrange
            List<string> expected = TestList2;

            // Act
            List<string> actual = Unionizer.Union(new List<string>(), TestList2);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Union_2ndListBlank()
        {
            // Arrange
            List<string> expected = TestList1;

            // Act
            List<string> actual = Unionizer.Union(TestList1, new List<string>());

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Union_BothListBlank()
        {
            // Arrange
            List<string> expected = new List<string>();

            // Act
            List<string> actual = Unionizer.Union(new List<string>(), new List<string>());

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Union_2ndListNull()
        {
            // Arrange
            List<string> expected = TestList1;

            // Act
            List<string> actual = Unionizer.Union(TestList1, null);

            // Assert
            Assert.Equal(expected, actual);

        }

        // Test takes much longer than other tests to execute 40ms(low)/110ms(high) compared to 1ms
        // TODO: find out why
        [Fact]
        public void Union_1stListNull()
        {
            // Arrange
            List<string> expected = TestList2;

            // Act
            List<string> actual = Unionizer.Union(null, TestList2);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Union_BothListsNull()
        {
            // Arrange
            List<string> expected = new List<string>();

            // Act
            List<string> actual = Unionizer.Union(null, null);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
