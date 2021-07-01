using System;
using System.Numerics;

namespace extraLargerFatorial
{
    class Program
    {
         public static void extraLongFactorials(int n)
        {
            BigInteger fatorial=1;
            while(n!=1){
                fatorial = fatorial * n;
                n = n-1;
            }
            Console.WriteLine(fatorial);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            extraLongFactorials(n);
        }
    }
}
