using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long totalSum = arr.Sum(x => (long)x); // Cast each element to long to avoid overflow

        // Sort the array
        arr.Sort();

        // Mini sum: sum of all elements except the largest one
        long miniSum = totalSum - arr[arr.Count - 1];

        // Max sum: sum of all elements except the smallest one
        long maxSum = totalSum - arr[0];
        
        // Output the results
        Console.WriteLine($"{miniSum} {maxSum}");

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.miniMaxSum(arr);
    }
}
