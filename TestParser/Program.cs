using System;

namespace TestParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args?.Length >= 1)
            {
                var words = Parser.Parse(args[0]);

                foreach (var key in words.Keys)
                {
                    Console.WriteLine($"Word: { key} , count: { words[key]}");
                }

                Console.ReadKey();//pause
            }

        }
    }
}
