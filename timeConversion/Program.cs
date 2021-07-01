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

namespace timeConversion
{
    class Program
    {
        public static string timeConversion(string s)
        {
            string amPm = "";
            string timeConverted = "";
            int hour = 0;
            amPm = s.Substring(s.Length -2,2);
            if(amPm == "PM"){
                if(s.Substring(0,2) == "12"){
                    timeConverted = s.Substring(0,s.Length-2);
                }
                else{
                    hour = int.Parse(s.Substring(0,2));
                    hour = hour + 12;
                    timeConverted = hour.ToString() + s.Substring(2,s.Length-4);
                }
            }
            else{
                if(s.Substring(0,2) == "12"){
                    timeConverted = "00" + s.Substring(2,s.Length-4);
                }
                else{
                    timeConverted = s.Substring(0,s.Length-2);
                }                
            }
            return timeConverted;
        }
        static void Main(string[] args)
        {           

            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);
        }
    }
}
