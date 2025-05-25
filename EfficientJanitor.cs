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
     * Complete the 'efficientJanitor' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts FLOAT_ARRAY weight as parameter.
     */

    public static int efficientJanitor(List<float> weight)
    {
        weight.Sort();
        int left = 0;
        int right = weight.Count - 1;
        int trips = 0;
        while (left <= right)
        {
        // If lightest + heaviest fits in one trip, use both
        if (weight[left] + weight[right] <= 3.0f)
        {
            left++;
        }

        // Always take the heaviest item
        right--;
        trips++;
        }
        
        return trips;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int weightCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<float> weight = new List<float>();

        for (int i = 0; i < weightCount; i++)
        {
            float weightItem = Convert.ToSingle(Console.ReadLine().Trim());
            weight.Add(weightItem);
        }

        int result = Result.efficientJanitor(weight);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
