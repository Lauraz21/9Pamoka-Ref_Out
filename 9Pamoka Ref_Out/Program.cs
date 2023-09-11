//1.1

namespace _9Pamoka_Ref_Out
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Swap(ref x, ref y);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
        public static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
    }
}












