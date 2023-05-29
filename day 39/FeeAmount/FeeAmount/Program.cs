using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FeeAmount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student type");
            string studentType = Console.ReadLine();
            Console.WriteLine("Enter tutuion fee");
            float tutionFee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter bus fee");
            float busFee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hostel fee");
            float hostelFee = float.Parse(Console.ReadLine());
            float totalFee = 0.0f;


            if (studentType == "MSDS")
            {
                totalFee = tutionFee + busFee;
            }
            else if (studentType == "MSH")
            {
                totalFee = tutionFee + hostelFee;
            }
            else if (studentType == "MGSDS")
            {
                totalFee = 1.5f * tutionFee + busFee;
            }
            else if (studentType == "MGSH")
            {
                totalFee = 1.5f * tutionFee + hostelFee;
            }
            Console.WriteLine("The fess to be paid by the student is {0}",+totalFee);
       
        }
    }
}

