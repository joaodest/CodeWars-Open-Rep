using System.Linq;

namespace Kata
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int[] input = new[] { 1, 2, 3 };
            int input2 = 4;

            Console.WriteLine(TwoSum(input, input2));
        }


        public static int[] TwoSum(int[] numbers, int target)
        {
            var sum = numbers
                .SelectMany((num1, index1) =>
                numbers.Select((num2, index2) =>
                new { Number1 = num1, Number2 = num2, Index1 = index1, Index2 = index2 })
                .Where(pair => pair.Index1 < pair.Index2)
                )
                .FirstOrDefault(pair => pair.Number1 + pair.Number2 == target);


            return  new int[] { sum.Index1, sum.Index2 };

        }
    }


}