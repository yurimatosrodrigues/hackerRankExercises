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

namespace C_
{
    class Program
    {


        public static int birthdayCakeCandles(List<int> candles){
            int max = candles.Max();
            int countMax = 0;
            foreach(int candle in candles){
                if(candle == max){countMax++;}
            }
            return countMax;
        }

        static void Main(string[] args)
        {            
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);

            Console.WriteLine(result);           
            
        }

        
    }
}
