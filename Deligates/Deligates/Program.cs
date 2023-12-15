using System;

namespace Deligates
{
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string str);
    class Program
    {
        public void AddNums( int x, int y ) 
        {
            
            Console.WriteLine(x + y);
        }
        public static string SayHello(string name)
        {
            return "Hai " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate ad = new AddDelegate(p.AddNums);
            //ad(10, 5);
            ad.Invoke(10, 5);
            SayDelegate sd = new SayDelegate(SayHello);
            string str = sd("shiva");//sd.Invoke("shiva);
            Console.WriteLine(str);
        }
    }
}
