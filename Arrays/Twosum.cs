/*
Leetcode Problem : Two sum

Problem:
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

Naive solution : will be to loop through the elements in nested loop and calculate the sum of elements for target sum.
But it will have time complexitiy of O(n^2).

Better solution: will be to use the Dictionary<int compliment, int index>

 */

 using System;
 using System.Collections.Generic;

 public class Twosum
 {
     public static void Main(string [] args)
     {
         int[] inputArray = new int[] {9, 7, 11, 0};
         int targetSum = 9;
         Dictionary<int,int> compliments = new Dictionary<int,int>();
         int compValue = 0;
         string result = String.Empty;
         bool processflag = false;
         int[] output = new int[2];


         // loop through the array elements to store compliments in dictionary along with their subscripts

         for(int i = 0 ; i < inputArray.Length ; i ++)
         {
             // check if the array value is present in the dictionary
             if(compliments.ContainsKey(inputArray[i]))
             {
                 // means we have found the matching pair
                 processflag = true;
                 int value = 0;
                 compliments.TryGetValue(inputArray[i], out value);
                 result += value.ToString() + " " + i.ToString();
                 string[] temp = result.Split(' ');
                 output[0] = Int32.Parse(temp[0]);
                 output[1] = Int32.Parse(temp[1]);
                 break;

             }
             else
             {
                 compValue = targetSum - inputArray[i];

                if(!compliments.ContainsKey(compValue))
                {
                    compliments.Add(compValue,i);
                }

             }
         }

         if(processflag)
         {
             Console.WriteLine("Output:"+result);
             
         }
     }
 }