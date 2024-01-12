using System.ComponentModel.Design;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x, F;
            Console.WriteLine("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x < 3.2)
            {
                F = -Math.Pow(x, 2) + 9;

            }
            else
            {
                F = Math.Pow(x, 2) + 3 * x + 9;
            }
            Console.WriteLine ("F = ");
        }
    }
}