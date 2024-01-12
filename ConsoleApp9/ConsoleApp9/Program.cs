using System;
namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            double[] b = new double[3];
            b[0] = a[0];
            b[1] = a[k];
            b[2] = a[2 * k];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i + 1}] = ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < k; i++)
            {
                if (b[0] < a[i])
                {
                    b[0] = a[i];
                }
            }
            for (int i = k; i < 2 * k; i++)
            {
                if (b[1] < a[i])
                {
                    b[1] = a[i];
                }
            }
            for (int i = 2 * k; i < n; i++)
            {
                if (b[2] < a[i])
                {
                    b[2] = a[i];
                }
            }
            foreach (double i in b)
                Console.Write($"{i} ");
        }
    }
}