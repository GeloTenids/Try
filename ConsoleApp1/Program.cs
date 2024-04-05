using System;
using ClassLibrary1BL;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 hel = new Class1();
            Console.WriteLine(hel.Hello());
            Console.WriteLine(hel.Hi());
        }
    }
}
