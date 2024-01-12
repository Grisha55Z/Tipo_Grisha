using System;
namespace fvjvec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("m =");
            int m = 3 * Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n =");
            int n = 1 * Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("k =");
            int k = 2 * Convert.ToInt32(Console.ReadLine());
            int result = m + n + k;
            Console.WriteLine(result);
    }   }
}