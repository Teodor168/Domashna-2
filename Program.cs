
using System.Collections;
namespace Domashna_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList() { -3, 5, 1, 9, -12, 4, 6, -2, 0 };

            Console.WriteLine(string.Join(", ", numbers.ToArray()));
            Console.WriteLine();

            ReplaceNegativesWithZero(numbers);
            Console.WriteLine(string.Join(", ", numbers.ToArray()));
            Console.WriteLine();

            int sumOfPositives = SumOfPositives(numbers);
            Console.WriteLine(sumOfPositives);
            Console.WriteLine();

            FindMaxMinDifference(numbers);
        }

        static void ReplaceNegativesWithZero(ArrayList numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int num = (int)numbers[i]; 
                if (num < 0)
                {
                    numbers[i] = 0; 
                }
            }
        }

        static int SumOfPositives(ArrayList numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        static void FindMaxMinDifference(ArrayList numbers)
        {
            int maxValue = (int)numbers[0];
            int minValue = (int)numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                int num = (int)numbers[i]; 

                if (num > maxValue)
                {
                    maxValue = num;
                }

                if (num < minValue)
                {
                    minValue = num;
                }
            }

            int difference = maxValue - minValue;
            Console.WriteLine("Max = " + maxValue);
            Console.WriteLine("Min = " + minValue);
            Console.WriteLine("difference: " + difference);
        }
    }
}