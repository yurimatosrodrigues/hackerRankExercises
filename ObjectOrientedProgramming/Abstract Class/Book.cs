using System;
namespace AbstractClass{
    public abstract class Book{
        public string? title;

        public abstract void SetTitle(string? s);
        public string GetTitle(){
            return title??"";
        }
    }
}