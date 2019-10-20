/*
EPI 5.6
Problem: Give an array containing daily stock prices of a share, calculate the maximum profit that can be made by buying and selling
one share of that stock.Subject to the constraint that buy and sell have to take place at the start of the day.

example : [310,315,275,295,260,270,290,230,255,250] : Max profit will be 30, i.e buy at 260 and sell at 290

Naive solution could be to use the nested for loop and compare each element with other elements in array to calculate the max profit.
But this has time complexity of O(n^2).

Better solution will be if we can track the profit and minimum so far in linear pass of array, O (n)

Best solution could be using Divide and conquer, which will try later

 */

 using System;

 public class BuyAndSellStockOnce{

     public static void Main(string [] args)
     {
         int[] inputArray = new int[] {210,315,275,295,260,270,290,230,255,250};
         int lastMaxProfit = 0;
         int currentProfit = 0;
         int currentMinimum = 0;

         // Loop through array elements 
         for (int i = 0; i < inputArray.Length-1 ; i ++)
         {
             if(i==0)
             {
                 currentMinimum = inputArray[i];
                 currentProfit = inputArray[i] - currentMinimum;
                 lastMaxProfit = currentProfit;
             }
             if(inputArray[i] < currentMinimum)
             {
                 currentMinimum = inputArray[i];
                 currentProfit = 0;


             }else{
                 currentProfit = inputArray[i] - currentMinimum;
             }

             if(currentProfit > lastMaxProfit)
             {
                 lastMaxProfit = currentProfit;
             }
         }

         // Print the max profit 
         Console.WriteLine("Maximum profit made :"+ lastMaxProfit);
     }
 }