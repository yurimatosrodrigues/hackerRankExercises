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


namespace _2D_Array___DS
{
    class Program
    {
        static int hourglassSum(int[][] arr) {
        int sum = 0;
        int max = 0;               
        
        for(int row = 0; row <= arr.GetLength(0) - 3; row++){
            for(int column = 0; column <= 6 - 3; column++){
                sum += arr[row][column];
                sum += arr[row][column+1];
                sum += arr[row][column+2];                

                sum += arr[row+1][column+1];

                sum += arr[row+2][column];
                sum += arr[row+2][column+1];
                sum += arr[row+2][column+2];
                
                if(row == 0 && column == 0) max = sum;                
                else if(sum > max) max = sum;                  
                sum = 0;
            }                        
        }
        return max;
    }
        static void Main(string[] args)
        {                       
            int[][] arr = new int[6][];

            Console.WriteLine("Write your 2D array with the hourglass: ");

            for (int i = 0; i < 6; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.WriteLine(result);
        }
    }
}
