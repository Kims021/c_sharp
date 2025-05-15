using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        A.Sort();            // ascending
        B.Sort();            // ascending
        B.Reverse();         // now descending

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] + B[i] < k)
            {
                return "NO";
            }
        }

        return "YES";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().Trim().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> A = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            List<int> B = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            string result = Result.twoArrays(k, A, B);

            Console.WriteLine(result);
        }
    }
}
