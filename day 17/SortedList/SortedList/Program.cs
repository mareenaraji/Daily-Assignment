using System;
using System.Collections;
class Class1
{
    static void Main(string[] args)
    {
        SortedList s = new SortedList();
        s.Add("Maharastra ", "Mumbai");
        s.Add("Karnataka ", "Bangalore");
        s.Add("Andhra Pradesh", "Hyderabad");
        s.Add("Tamilnadu ", "chennai");
        s.Add("Bihar ", "Patna");
        s.Add("Rajastan ", "Jaipur");
        s.Add("Orissa ", "Bhubaneshwar");
        Console.WriteLine("Elements in the SotredList: ");
        IDictionaryEnumerator e = s.GetEnumerator();
        while (e.MoveNext())
            Console.WriteLine(e.Key + "\t" + e.Value);

        //foreach (SortedList item in s)
        //{
        //  Console.WriteLine(item.Keys.ToString());
        //}
        s.Remove("TamilNadu");
        Console.WriteLine("The Keys are : ");
        ICollection k = s.Keys;
        foreach (object i in k)
            Console.WriteLine(i + " ");
        Console.WriteLine("The Values are : ");
        ICollection v = s.Values;
        foreach (object i in v)
            Console.WriteLine(i + " ");
        Console.WriteLine("Value at 3rd Index 3: "
        + s.GetByIndex(3));
        Console.WriteLine("Key at 3rd Index: "
        + s.GetKey(3));
        Console.WriteLine("The Index of key Bihar"
        + s.IndexOfKey("Bihar"));
        Console.WriteLine("The Index of value Jaipur"
        + s.IndexOfValue("Jaipur"));
    }
}
  