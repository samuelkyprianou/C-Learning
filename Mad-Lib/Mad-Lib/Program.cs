using System;

namespace Mad_Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            string colour, pluralNoun, celebrity;

            Console.Write("Enter a colour: ");
            colour = Console.ReadLine();
            Console.Write("Enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + colour);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
        }
    }
}
