# HackerRank 1-Month Preparation Kit

This repository contains solutions to the problems from the **HackerRank 1-Month Preparation Kit**. I am compiling my solutions here as I work through the challenges on HackerRank to improve my problem-solving skills and prepare for coding interviews.

## About the Preparation Kit

HackerRank's **1-Month Preparation Kit** is designed to help you prepare for coding interviews by covering important algorithms and data structures. It includes a series of practice problems that span various domains such as **Sorting**, **Greedy Algorithms**, **Dynamic Programming**, **Arrays**, **Strings**, **Searching**, and more.

## List of Problems Solved

Here are the problems I have solved as part of the preparation kit:

1. [Plus Minus](#) - Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with places after the decimal.

2. [Mini-Max Sum](#) - Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

3. [Time Conversion](#) - Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
   Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.

- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

4.  [Sparse Arrays](#) - There is a collection of input strings and a collection of query strings. For each query string, determine how many times it occurs in the list of input strings. Return an array of the results.

5.  [Lonely Integer](#) - Given an array of integers, where all elements but one occur twice, find the unique element.

    Example
    a = [1,2,3,5,3,2,1]
    The unique element is 5.

6.  [Flipping Bits](#) - You will be given a list of 32 bit unsigned integers. Flip all the bits (1 -> 0 and 0 -> 1 ) and return the result as an unsigned integer.

7.  [Diagonal Difference](#) - Given a square matrix, calculate the absolute difference between the sums of its diagonals.
    For example, the square matrix arr is shown below:

        Example
        3
        11 2 4
        4 5 6
        10 8 -12

        Sample Output: 15

        Explanation

        The primary Diagonal is:
        11
          5
           -12
        Sum across the primary diagonal: 11 + 5 - 12 = 4

        The secondary diagonal is:

             4
          5
        10

        Sum across the secondary diagonal: 4 + 5 + 10 = 19
        Difference: |4 - 19| = 15

        Note: |x| is the absolute value of x

8.  [Counting Sort 1](#) - You will be given a list of 32 bit unsigned integers. Flip all the bits (1 -> 0 and 0 -> 1 ) and return the result as an unsigned integer.

i arr[i] result
0 1 [0, 1, 0, 0]
1 1 [0, 2, 0, 0]
2 3 [0, 2, 0, 1]
3 2 [0, 2, 1, 1]
4 1 [0, 3, 1, 1]

9. [Pangrams](#) - A pangram is a string that contains every letter of the alphabet. Given a sentence determine whether it is a pangram in the English alphabet. Ignore case. Return either pangram or not pangram as appropriate.

Example

The string contains all letters in the English alphabet, so return pangram.

Function Description

Complete the function pangrams in the editor below. It should return the string pangram if the input string is a pangram. Otherwise, it should return not pangram.

pangrams has the following parameter(s):

string s: a string to test
Returns

string: either pangram or not pangram
Input Format

A single line with string .

Constraints

Each character of ,

Sample Input

Sample Input 0

We promptly judged antique ivory buckles for the next prize

Sample Output 0

pangram

Sample Explanation 0

All of the letters of the alphabet are present in the string.

Sample Input 1

We promptly judged antique ivory buckles for the prize

Sample Output 1

not pangram

Sample Explanation 0

The string lacks an x.

10. [Permuting Two Arrays](#) - There are two -element arrays of integers, and . Permute them into some and such that the relation holds for all where .

There will be queries consisting of , , and . For each query, return YES if some permutation , satisfying the relation exists. Otherwise, return NO.

Example

A valid is and : and . Return YES.

Function Description

Complete the twoArrays function in the editor below. It should return a string, either YES or NO.

twoArrays has the following parameter(s):

int k: an integer
int A[n]: an array of integers
int B[n]: an array of integers
Returns

- string: either YES or NO

Input Format

The first line contains an integer , the number of queries.

The next sets of lines are as follows:

The first line contains two space-separated integers and , the size of both arrays and , and the relation variable.
The second line contains space-separated integers .
The third line contains space-separated integers .
Constraints

Sample Input

STDIN Function

---

2 q = 2
3 10 A[] and B[] size n = 3, k = 10
2 1 3 A = [2, 1, 3]
7 8 9 B = [7, 8, 9]
4 5 A[] and B[] size n = 4, k = 5
1 2 2 1 A = [1, 2, 2, 1]
3 3 3 4 B = [3, 3, 3, 4]
Sample Output

YES
NO







## Problem Solving Approach

For each problem, I have followed a systematic approach to arrive at an efficient solution:

1. **Understanding the Problem:** Reading the problem description carefully and making sure I understand the input, output, and constraints.
2. **Planning the Approach:** Choosing the appropriate algorithm/data structure to solve the problem, optimizing for time and space complexity where possible.
3. **Writing the Code:** Implementing the solution and making sure it runs correctly.
4. **Testing the Solution:** Running the code against various test cases to ensure it handles edge cases.

## Repository Structure

The repository is organized as follows:
