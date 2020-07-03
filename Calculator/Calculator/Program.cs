using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Another Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
    }
}
