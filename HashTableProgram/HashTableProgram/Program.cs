using System;
using System.Collections;

namespace HashTableProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"hai");
            ht.Add(2,"Hello");
            ht.Add("three", 3);
            ht.Add("four", null);
            ht[3] = "Shiva";
            try
            {
                ht.Add(2, 100);
            }
            catch
            {
                Console.WriteLine("An element with key 2 is already exists");
            }
            foreach (DictionaryEntry a in ht)
            {
                Console.WriteLine("Key = {0} , Value = {1}",a.Key,a.Value);
            }
        }
    }
}
