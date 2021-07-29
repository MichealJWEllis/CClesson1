using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "hello";
            greeting = greeting + "world";
            Console.WriteLine("greeting" + greeting);
            Console.WriteLine($"greeting {greeting}");
            Console.WriteLine("greeting: {0}", greeting);
            //Console.WriteLine("Hello World!");
        }
    }
}
