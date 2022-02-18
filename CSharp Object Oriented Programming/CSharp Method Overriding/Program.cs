using System;
namespace MethodOverriding{

    class Sports{
        virtual protected internal string GetName(){
            return "Generic Sports";
        }
        virtual protected internal void GetNumberOfTeamMembers(){
            Console.WriteLine("Each team has n players in " + GetName());
        }
    }

    class Soccer : Sports{
        override protected internal string GetName(){
            return "Soccer Class";
        }

        override protected internal void GetNumberOfTeamMembers(){
            Console.WriteLine("Each team has 11 players in " + GetName());
        }
    }

    class Program{
        static void Main(){
            Sports c1 = new Sports();
            Soccer c2 = new Soccer();
            Console.WriteLine(c1.GetName());
            c1.GetNumberOfTeamMembers();
            Console.WriteLine(c2.GetName());
            c2.GetNumberOfTeamMembers();
        }
    }
}