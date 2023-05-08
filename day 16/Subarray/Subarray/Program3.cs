using System;

public class Program
{
    public static void subArraySum(int[] arr,int n,int sum)
    {
        for(int i=0;i<n;i++)
        {
            int currentSum = arr[i];
            if (currentSum == sum)
            {
                Console.WriteLine("Sum found at index" + i);
                return;
            }
            else
            {
                for(int j=i+1;j<n;j++)
                {
                    currentSum += arr[j];
                    if(currentSum == sum)
                    {
                        Console.WriteLine("Sum found indexes " + i + " and " + j);
                        return;
                    }
                }
            }
        }
        Console.WriteLine("No subarray found");
        return;
    }
    public static void Main(string[] args)
    {
        int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
        int n = arr.Length;
        int sum = 23;
        subArraySum(arr,n,sum);

    }
}