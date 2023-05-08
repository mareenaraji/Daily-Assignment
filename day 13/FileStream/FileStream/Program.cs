using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream
{
    class Program
    {
        static string file = @"D:\poem.txt";
        static void Main()
        {
            Write();
            Read();
        }
        static void Write()
        {
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine("what is thus life if,full of care");
            fileStream.WriteLine("we hav no time to stand and stare");
            fileStream.Close();
        }
        static void Read()
        {
            StreamWriter fileStream = new StreamWriter(file);
            string s = null;
            while((s=fileStream.ReadLine())!=null)
            {
                Console.WriteLine(s);
            }
            fileStream.Close();
        }

    }
}
