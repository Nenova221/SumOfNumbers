using Microsoft.VisualStudio.TestPlatform.TestHost;
using SumOfNumbers;

namespace SumOfNumbersTest
{
    public class SumOfNumbersTest
    {
        [Theory]
        [InlineData(3, new int[] { 3, 2, 3 }, 8)]     // Тест с 3 числа
        [InlineData(7, new int[] { -4, -2, -3, -2, -1, -2, -6 }, -20)] // Тест с отрицателни числа
        [InlineData(5, new int[] { 3, 9, 11, 7, 2}, 32)]             // Тест с n = 0
        public void SumOfNumbers_WithInputNumbers_ShouldTestSumOfTheNumbers(int n, int[] numbers, int expectedSum)
        {
            int actualSum = Sum.SumOfNumbers(n, numbers);
            Assert.Equal(expectedSum, actualSum);
        }
    }
}