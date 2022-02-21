using System;
using System.Collections;

namespace InstanceOfKeyword{
    class Student{}
    class RockStar{}
    class Hacker{}

    class Program{
        static string Count(ArrayList mylist){
            int a = 0,b = 0,c = 0;
            for(int i = 0; i < mylist.Count; i++){
                //Object element = mylist. ;
                if(mylist[i].GetType() == typeof(Student))
                    a++;
                if(mylist[i].GetType() == typeof(RockStar))
                    b++;
                if(mylist[i].GetType() == typeof(Hacker))
                    c++;
            }
            String ret = a.ToString() +" "+ b.ToString() +" "+ c.ToString();
            return ret;
        }

        static void Main(){
            ArrayList myList = new ArrayList();
            var t = int.Parse(Console.ReadLine());
            for(int i=0; i<t; i++){
                string s = Console.ReadLine();
                if(s.Equals("Student")) myList.Add(new Student());
                if(s.Equals("Rockstar")) myList.Add(new Student());
                if(s.Equals("Hacker")) myList.Add(new Student());
            }
            Console.WriteLine(Count(myList));
        }
    }
}