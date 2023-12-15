using System;
using System.Collections;

namespace CollectionsHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("EName", "firoz");
            ht.Add("job", "Manager");
            ht.Add("salary", 25000);
            ht.Add("Mgrid", 1002);
            ht.Add("phone", 9876543210);
            ht.Add("Email","iamtheboss@gmail.com");
            ht.Add("Dname", "Sales");
            ht.Add("Location", "hyderabad");
            ht.Add("Did", 30);

            //Console.WriteLine(ht["Email"]);

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key+": "+ ht[key]);
            }
        }
    }
}
