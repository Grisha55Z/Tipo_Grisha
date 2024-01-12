namespace ClassLibrary1
{
    public class Class1
    {
        public int PoKrasote(int x, int y) 
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            int z = x - y;
            Console.WriteLine("Разность этих двух чисел: {0}", z);
            return z;
        }
    }
}