using FirstUnitTest;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheQuadraticEquation equation = new TheQuadraticEquation(3, 9, 3);
            int expected = equation.roots.Length;
            Console.WriteLine(equation.roots[0]);
            Console.WriteLine(equation.roots[1]);
        }
    }
}