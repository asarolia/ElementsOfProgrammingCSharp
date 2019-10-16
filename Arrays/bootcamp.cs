/*
Problem statement : Given an array of integers, we need to reorder the entries in such a way that all even entries comes first in array.
Point to kept in mind that we should not increase the space complexities.

Clarifications: entires can come in any order just make sure that even are together and in start of array

Brute force/Naive solutions:

1) With space complexity of O(n): Create another array of equal size and loop through the elements from first array and
placing the even and odd elements at start and end postions respectively. Time complexity will be O(n)

2) With time complexity of O(n^2): Use nested loop within same array and swap the element positions with no new space complexity.

Efficient solution: time complexity O(n) and space complexity o(1)
OPerate the array element from both end at the same time and swap positions 

 */
using System;

public class Bootcamp
{
    public static int[] inputArray = {1,9,8,6,4,7,5};

    public static void Main(string[] args)
    {
        int start = 0;
        int end = inputArray.Length - 1;
        int temp = 0;

        // loop through the array elements 
        while (start < end)
        {
            //validate start array element 
            if(inputArray[start]%2 == 0)
            {
                // means element is even, so just skip to next 
                start++;
            }
            else
            {
                // start element is odd, now validate end element 
                if(inputArray[end]%2 != 0)
                {
                    // means element is odd, so skip to next from end
                    end --;
                }else
                {
                    // end element is even, so swap
                    temp = inputArray[end];
                    inputArray[end] = inputArray[start];
                    inputArray[start] = temp;

                    start++;
                    end--;

                }


            }
        } 

        // Print the Array 
        Console.WriteLine("Output array:");
        foreach(int i in inputArray)
        {
            Console.Write(i);
        }

    }
}

