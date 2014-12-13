using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoddingGround
{
    class Fibo
    {

        private static long CalculateFibonacci(long n)
        {
            if (n == 0 || n == 1) return n;
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }


        static int Main(string[] args)
        {
            long number = 0;
            Console.WriteLine("Enter a small positive natural number");
            Console.WriteLine("It is better you enter a number lower than 48");
            try
            {
                Console.Write("Enter the number: ");
                number = long.Parse(Console.ReadLine());
                Console.WriteLine("Fibonacci of {0} is {1}", number,
                 CalculateFibonacci(number));
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Value!");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            return 0;
        }
    }
}
