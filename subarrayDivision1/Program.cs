using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static int birthday(List<int> s, int d, int m)
    {
        int count = 0;

        for (int i = 0; i <= s.Count - m; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                sum += s[i + j];
            }

            if (sum == d)
            {
                count++;
            }
        }

        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

        string[] firstMultipleInput = Console.ReadLine().Trim().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

        Console.WriteLine(result);
    }
}
