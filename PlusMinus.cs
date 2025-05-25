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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
       int positiveNumberCount = 0;
       int negativeNumberCount = 0;
       int zeroNumberCount = 0;
       int size = arr.Count;
       
       foreach(var number in arr){
         if(number == 0)
         {
            zeroNumberCount++;
         }else if(number > 0)
         {
            positiveNumberCount++;
         }
         else{
            negativeNumberCount++;
         }
       }
       
    //   Console.WriteLine(positiveNumberCount);
    //   Console.WriteLine(size); 
       
       decimal postiveNumber =  (decimal)positiveNumberCount/size;
       decimal negativeNumber = (decimal)negativeNumberCount/size;
       decimal zeroNumber  = (decimal)zeroNumberCount/size;
       
    //    Console.WriteLine(Math.Round(postiveNumber, 6));
       Console.WriteLine(Math.Round(postiveNumber, 6));
       Console.WriteLine(Math.Round(negativeNumber, 6));
       Console.WriteLine(Math.Round(zeroNumber, 6));
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
