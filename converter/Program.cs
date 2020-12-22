using System;

namespace converter
{
    class Program
    {
        static void Main(string[] args)
        {
            float dollars, PLN, result, conversion_rate;
            conversion_rate = 0.27f;
            Console.Write("Enter amount in PLN: ");
            PLN = float.Parse(Console.ReadLine());
            dollars = conversion_rate * PLN;
            Console.WriteLine("Amount in Dollars is: "+dollars+ "USD");
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
