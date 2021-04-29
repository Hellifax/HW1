using System;

namespace homeWork_1
{
    class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine(" Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, today is {DateTime.Now}");
        }
    }
}
