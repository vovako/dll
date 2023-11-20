using System;

namespace volodyaLibrary
{
    public class volodya
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
        public double sum(double a, double b)
        {
            return a + b;
        }
        public double minus(double a, double b)
        {
            return a - b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public double pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
