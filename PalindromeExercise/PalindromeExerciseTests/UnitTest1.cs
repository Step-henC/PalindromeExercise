using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData(null, false)]
        [InlineData("kayak", true)]
        [InlineData("mountain", false)]
        [InlineData("madam", true)]
        [InlineData("cantankerous", false)]
        [InlineData("", false)]
        [InlineData("a    a", true)]
        

        public void Test1(string str, bool expected)
        {
            var test = new PalindromeExercise.WordSmith();

            var actual = test.IsAPalindrome(str);
            Assert.Equal(expected, actual); 

        }
    }
}
