using System;
using System.Collections;

namespace InstanceOfKeyword{
    class Student{}
    class Rockstar{}
    class Hacker{}

    class Program{
        static string Count(ArrayList mylist){
            int a = 0,b = 0,c = 0;            
            for(int i = 0; i < mylist.Count; i++){                
                if(mylist[i] is Student)
                    a++;
                if(mylist[i] is Rockstar)
                    b++;
                if(mylist[i] is Hacker)
                    c++;
            }
            String ret = a.ToString() +" "+ b.ToString() +" "+ c.ToString();
            return ret;
        }

        static void Main(){
            ArrayList myList = new ArrayList();
            string? r = Console.ReadLine();
            int t;
            if (!int.TryParse(r, out t)) return;
            for(int i=0; i<t; i++){
                string? s = Console.ReadLine();
                if(s is not null){
                    if(s.Equals("Student")) myList.Add(new Student());
                    if(s.Equals("Rockstar")) myList.Add(new Rockstar());
                    if(s.Equals("Hacker")) myList.Add(new Hacker());
                }
            }
            Console.WriteLine(Count(myList));
        }
    }
}