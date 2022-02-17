using System;
namespace AbstractClass{

     public class MyBook : Book{
            public override void SetTitle(string? s){
                title = s;
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