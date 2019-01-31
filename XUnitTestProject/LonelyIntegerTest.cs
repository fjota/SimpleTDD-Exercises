using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TDDExampleExercises;

namespace XUnitTestProject
{
    public class LonelyIntegerTest
    {
        private readonly LonelyInteger lonelyInteger;

        public LonelyIntegerTest()
        {
            lonelyInteger = new LonelyInteger();
        }

        [Theory]
        [InlineData(new[] { 0, 1, 2, 1, 0 }, 2)]
        [InlineData(new[] { 0,2,0 }, 2)]
        [InlineData(new[] { 0,2,5,7,9,7,1,2,9,5 }, 0)]
        public void TestLonelyInteger(int[] arr, int expected)
        {
            var result = lonelyInteger.LonelyInteger1(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueIntegerInArray()
        {
            int expected = 1;
            var result = lonelyInteger.LonelyInteger1(new[] { 1 });
            Assert.Equal(expected, result);
        }

        [Fact]
        public void NullParameter()
        {            
            Action result = () => lonelyInteger.LonelyInteger1(null);
            Assert.Throws<NullReferenceException>(result);
        }
        
        [Fact]
        public void NotFoundLonelyInteger()
        {
            int expected = -1;
            var result = lonelyInteger.LonelyInteger1(new[] { 5, 8, 6, 6, 5, 8 });
            Assert.Equal(expected, result);
        }
    }
}
