using System;


namespace AnonymousAdd
{
    internal class Program
    {
        public delegate int sum(int i, int j);
        static void Main(string[] args)
        {
            int result;
            sum a = delegate (int x, int y)
            {
                return x + y;
            };
            result =a(20, 30);
            Console.WriteLine(result);
            
        }
    }
}
