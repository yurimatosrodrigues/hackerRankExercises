using System;
namespace Inheritance_II{     

    public class Adder : Arithmetic{
    }
    
    class Program{
        static void Main(){
            Adder a = new Adder();

            Console.WriteLine("My superclass is: " + a.GetType().BaseType?.Name);
            Console.WriteLine(a.Add(10,32) + " " + a.Add(10,3) + " " + a.Add(10,10));
        }
    }
}