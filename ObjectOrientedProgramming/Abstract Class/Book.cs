using System;
namespace AbstractClass{
    abstract class Book{
        protected string? _title;
        protected internal abstract void SetTitle(string? s);
        protected internal string GetTitle(){
            return _title ?? "";
        }
    }
}