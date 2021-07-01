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
namespace gradingStudents
{
    class Program
    {

        public static List<int> gradingStudents(List<int> grades){
            List<int> finalGrade = new List<int>();
            foreach(int grade in grades){
                if(grade < 38){
                    finalGrade.Add(grade);
                }
                else{
                    if ((grade % 5) == 0){
                        finalGrade.Add(grade);
                    }
                    else{
                        int countMultiples = grade;
                        while((countMultiples % 5) != 0){
                            countMultiples +=1;                            
                        }
                        if((countMultiples - grade) < 3){
                            finalGrade.Add(countMultiples);
                        }
                        else{
                            finalGrade.Add(grade);
                        }
                    }
                }                
            }
            return finalGrade;
        }

        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));


            
        }
    }
}
