using System;

namespace Gutis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Double f = x * x * x * 6 + 3;
            Console.WriteLine(f);
        }
    }
}