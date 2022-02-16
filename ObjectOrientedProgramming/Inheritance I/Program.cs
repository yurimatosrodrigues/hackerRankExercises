﻿using System;
namespace Inheritance_I{      

    public class Animal{
       public void Walk(){
           Console.WriteLine("I am walking");
       }
    }

    public class Bird : Animal{
        public void Fly(){
            Console.WriteLine("I am flying");
        }

        public void Sing(){
            Console.WriteLine("I am singing");
        }
    }

    class Solution{
        static void Main(){
            Bird bird = new Bird();
            bird.Walk();
            bird.Fly();
            bird.Sing();
        }
    }
}