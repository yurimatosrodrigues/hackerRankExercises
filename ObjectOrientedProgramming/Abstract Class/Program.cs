using System;
namespace AbstractClass{

     class MyBook : Book{
            protected internal override void SetTitle(string? s){
                _title = s;
            }
        }

    public class Program{
        static void Main(){            
            string? title = Console.ReadLine();
            MyBook myBook = new MyBook();
            myBook.SetTitle(title);
            Console.WriteLine("The title is: {0}", myBook.GetTitle());                        
        }
    }
}