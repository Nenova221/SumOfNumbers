using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    public class Sum
    {
        public static int SumOfNumbers(int n, int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = SumOfNumbers(n, numbers);
            Console.WriteLine($"The sum of the {n} numbers is: {sum}");
        }
    }
}
