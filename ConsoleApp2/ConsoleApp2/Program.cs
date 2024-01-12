namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");

            int x = Convert.ToInt32(Console.ReadLine());
            double f = x / 5 - 32;

            Console.WriteLine(f);
        }
    }
}