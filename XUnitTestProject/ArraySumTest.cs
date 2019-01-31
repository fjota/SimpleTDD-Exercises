using System;
using Xunit;
using TDDExampleExercises;

namespace XUnitTestProject
{
    public class ArraySumTest
    {        
        private readonly ArraySum arraySum;

        public ArraySumTest()
        {
            arraySum = new ArraySum();
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 6)]
        [InlineData(new[] { 5, 5 }, 10)]
        [InlineData(new[] { 5, 8 }, 13)]
        public void TestArraySum(int[] arr, int expected)
        {
            var result = arraySum.SimpleArraySum(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void NullParameter()
        {
            Action result = () => arraySum.SimpleArraySum(null);
            Assert.Throws<ArgumentNullException>(result);
        }

        [Fact]
        public void OverflowIntegerSum()
        {
            var arr = new[] { int.MaxValue, int.MaxValue };
            Action result = () => arraySum.SimpleArraySum(arr);
            Assert.Throws<OverflowException>(result);
        }
    }
}
