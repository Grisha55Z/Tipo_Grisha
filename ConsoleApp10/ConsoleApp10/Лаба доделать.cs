using System.Text.Json.Serialization;
using System.Threading.Channels;
using System.Xml.Linq;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double xN;
            double s;
            double y = 0;
            double S;

            do
            {
                
                do
                {
                    y = y + 1;
                    xN = Math.Pow(x, N);
                    s = Math.Sin(xN);


                }
                while (y != N);
                S = xN + Math.Pow(xN, y);

            }
            while (y != N);
            Console.WriteLine($"s = {S}");
        }
    }
}