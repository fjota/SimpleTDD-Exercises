using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TDDExampleExercises;

namespace XUnitTestProject
{
    public class CamelCaseTest
    {
        /* Print the number of words in string */

        private readonly CamelCase camelCase;

        public CamelCaseTest()
        {
            camelCase = new CamelCase();
        }

        [Fact]
        public void NullParameter()
        {
            Action result = () => camelCase.CamelCase1(null);
            Assert.Throws<ArgumentNullException>(result);
        }

        [Theory]
        [InlineData("testCamelCase", 3)]
        [InlineData("saveChangesInTheEditorHelloWorld", 7)]
        [InlineData("saveChangesInTheEditor", 5)]
        public void TestCamelCase(string s, int expected)
        {
            var result = camelCase.CamelCase1(s);
            Assert.Equal(expected, result);
        }
    }
}
