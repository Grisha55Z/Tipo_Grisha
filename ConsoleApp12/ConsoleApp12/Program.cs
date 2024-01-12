namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                double Fx = (1/2)*(Math.Tan(a/4)+1);
                Console.WriteLine("x/tF(x) ");
            }
        }
    }
}