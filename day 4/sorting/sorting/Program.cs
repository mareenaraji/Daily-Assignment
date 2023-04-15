using System;

namespace sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 87, 34, 2, 43, 99, 10 };
            int temp;
            Console.WriteLine("Array before sort:");
            for(int i=0;i<6;i++)
            {
                Console.WriteLine(ar[i]+"\t");
            }
            Console.WriteLine();

            //sorting array
            for(int j=0;j<ar.Length;j++) 
            {
                for(int i=j;i<ar.Length-1;i++) 
                {
                    if (ar[j] > ar[i+1])
                    {
                        temp = ar[j];
                        ar[j]= ar[i+1];
                        ar[i+1]= temp;
                    }
                }
            }
            Console.WriteLine("Array after selection sort: ");
            for(int i=0;i<6;i++)
            {
                Console.WriteLine(ar[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
