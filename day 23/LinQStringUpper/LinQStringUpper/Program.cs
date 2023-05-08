using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQStringUpper
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string s = "Kerala is a God's Own Country";
            string result = s.myUpper();
            Console.WriteLine(result);
        }
        public static string myUpper(this string s)
        {
            return s.ToUpper();
        }
    }
}
