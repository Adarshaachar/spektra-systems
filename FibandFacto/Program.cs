using System.Numerics;
namespace FibandFacto
{
    internal class Program
    {
        static async Task<BigInteger> Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return await Task.Run(() => n * Factorial(n - 1).Result);
        }
        static async Task<BigInteger> Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;
            return await Task.Run(() => Fibonacci(n - 1).Result + Fibonacci(n - 2).Result);
        }
        static async Task Main(string[] args) 
        {
            BigInteger a = await Factorial(20);
            Console.WriteLine("factorial of 20 is:" + a);
            BigInteger b = await Fibonacci(20);
            Console.WriteLine("Fibonacci of 20th  term is:" + b);
        }
    }
}

