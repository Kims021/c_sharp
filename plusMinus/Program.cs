using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void plusMinus(List<int> arr)
    {
        int positiveCount = 0, negativeCount = 0, zeroCount = 0;
        int total = arr.Count;

        // Count positive, negative, and zero values
        foreach (var num in arr)
        {
            if (num > 0) positiveCount++;
            else if (num < 0) negativeCount++;
            else zeroCount++;
        }

        // Print the ratios of positive, negative, and zero values
        Console.WriteLine("\nnResult :: \n");
        Console.WriteLine($"{(double)positiveCount / total:F6}");
        Console.WriteLine($"{(double)negativeCount / total:F6}");
        Console.WriteLine($"{(double)zeroCount / total:F6}");
    }   
}

class Solution
{
    public static void Main(string[] args)
    {
        // Read the input size (not used directly, but it's needed for proper input parsing)
        Console.Write("Enter Limit :: ");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        // Read the list of integers and convert them into a List<int>
        Console.Write("Enter List numbers :: ");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ')
            .ToList()
            .Select(arrTemp => Convert.ToInt32(arrTemp))
            .ToList();

        // Call the plusMinus function to calculate and display the ratios
        Result.plusMinus(arr);
    }
}
