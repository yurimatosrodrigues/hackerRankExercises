using System;
namespace MethodOverridingII{
    public class MotorCycle : BiCycle{
        override public string Define_Me(){
            return "a cycle with an engine.";
        }
        public MotorCycle(){
            Console.WriteLine("Hello I am a motorcycle, I am " + Define_Me());
            string temp = base.Define_Me();
            Console.WriteLine("My ancestor is a cycle who is " + temp);
        }
    }
}