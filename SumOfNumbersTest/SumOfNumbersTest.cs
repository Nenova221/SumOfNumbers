using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json.Linq;
using SumOfNumbers;

namespace SumOfNumbersTest
{
    public class SumOfNumbersTest
    {
        [Theory]
        [InlineData(3, new int[] { 3, 2, 3 }, 8)]     
        [InlineData(7, new int[] { -4, -2, -3, -2, -1, -2, -6 }, -20)] 
        [InlineData(5, new int[] { 3, 9, 11, 7, 2}, 32)]             
        public void SumOfNumbers_WithInputNumbers_ShouldTestSumOfTheNumbers(int n, int[] numbers, int expectedSum)
        {
            int actualSum = Sum.SumOfNumbers(n, numbers);
            Assert.Equal(expectedSum, actualSum);
        }
        [Theory]
        [InlineData(3, new int[] { -6, 2, -15 }, 8)]     
        [InlineData(7, new int[] { -4, 5, 5, -2, -1, 23, -6 }, -20)] 
        [InlineData(5, new int[] { 3, 9, 11, 7, -1 }, 32)]
        public void SumOfNumbers_WithInvalidInputs_ShouldThrowExeption(int n, int[] numbers, int expectedSum)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Sum.SumOfNumbers(n, numbers, expectedSum));
        }
    }
}