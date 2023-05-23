using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays;
            weekdays = new string[] { "sun", "mon", "tue", "wed", "thur", "fri", "sat" };
            foreach(string day in weekdays)
            {
                Console.WriteLine(day);
                Console.WriteLine();
            }
        }
    }
}
