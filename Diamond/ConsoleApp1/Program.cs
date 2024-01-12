namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x - y;
            Console.WriteLine("Разность этих двух чисел: {0}", z);
        }
    }
}