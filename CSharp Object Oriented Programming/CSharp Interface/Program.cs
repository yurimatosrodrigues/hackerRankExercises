using System;
namespace Interface{
  interface AdvancedArithmetic{
        int Divisor_Sum(int n);
    }

   class MyCalculator : AdvancedArithmetic{
        public int Divisor_Sum(int n){
            int sum=0;
            for(int i=1; i <= n; i++){
                if(n % i == 0){
                    sum += i;
                }
            }
            return sum;
        }
    }

    class Program{

        static void ImplementedInterfacesNames(Object o){
            var _theInterfaces = o.GetType().GetInterfaces();
            for(int i=0; i < _theInterfaces.Length; i++){                
                Console.WriteLine(_theInterfaces[i].Name);                
            }
        }

        static void Main(){
            MyCalculator myCalculator = new MyCalculator();

            Console.Write("I implemented: ");
            ImplementedInterfacesNames(myCalculator);
            string? n = Console.ReadLine();
            int number;

            if(int.TryParse(n, out number)){
                Console.WriteLine(myCalculator.Divisor_Sum(number));   
            }
        }
    }
}