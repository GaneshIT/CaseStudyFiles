using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class Class1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numMap.ContainsKey(complement))
                    return new int[] { numMap[complement], i };

                numMap[nums[i]] = i;
            }

            return new int[0]; // No solution found
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> mapping = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

            foreach (char c in s)
            {
                if (mapping.ContainsKey(c))
                {
                    char top = stack.Count > 0 ? stack.Pop() : '#';
                    if (top != mapping[c])
                        return false;
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }

        public static int maxSum(int[] arr, int n, int k)
        {

            // n must be greater
            if (n <= k)
            {
                Console.WriteLine("Invalid");
                return -1;
            }

            // Compute sum of first window of size k
            int max_sum = 0;
            for (int i = 0; i < k; i++)
                max_sum += arr[i];

            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of
            // current window.
            int window_sum = max_sum;
            for (int i = k; i < n; i++)
            {
                window_sum += arr[i] - arr[i - k];
                max_sum = Math.Max(max_sum, window_sum);
            }

            return max_sum;
        }
    }
}
