using System;

namespace Get_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Your Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("You Are " + age + " Years Old");
        }
    }
}
