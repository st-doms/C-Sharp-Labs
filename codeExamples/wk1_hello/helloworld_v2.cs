using System;

namespace helloWorld_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
        }
    }
}
