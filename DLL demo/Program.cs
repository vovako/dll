using System;
using volodyaLibrary;

namespace DLL_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vova = new volodya();
            vova.SayHello();
            Console.WriteLine($"5 + 5 = {vova.sum(5, 5)}");
            Console.WriteLine($"5 - 5 = {vova.minus(5, 5)}");
            Console.WriteLine($"5 * 5 = {vova.multiply(5, 5)}");
            Console.WriteLine($"5 ^ 5 = {vova.pow(5, 5)}");
            Console.ReadKey();
        }
    }
}
