using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Damir!");
            string s1 = "hello";
            string s2 = null;

            string s3 = new String('g', 5);
            string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.ReadLine();

        }
    }
}