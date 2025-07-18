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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;
        int size = arr.Count;
        for(int i = 0; i < size; i++){
            // for(int j = 0; j < size; j++){
            //     if(i == j){
            //         primaryDiagonal += arr[i][j];
            //     }
            //      if (i + j == size - 1){
            //         secondaryDiagonal += arr[i][j]; 
            //      }   
            // }
            
            //O log(n)
            primaryDiagonal += arr[i][i];
            secondaryDiagonal += arr[i][size - 1 - i];
        }
        return Math.Abs(primaryDiagonal - secondaryDiagonal);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
