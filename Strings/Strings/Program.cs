using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\"World!");

            string phrase = "Hello World!";

            Console.WriteLine(phrase);
            Console.WriteLine(phrase + "it's me" );
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("World"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("W"));
            Console.WriteLine(phrase.Substring(6, 5));
        }
    }
}
