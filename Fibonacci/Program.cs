using System;

namespace Finonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsFibonacci(0));
            Console.WriteLine(IsFibonacci(1));
            Console.WriteLine(IsFibonacci(3));
            Console.WriteLine(IsFibonacci(6));
            Console.WriteLine(IsFibonacci(512));
            Console.WriteLine(IsFibonacci(987));
            Console.WriteLine(IsFibonacci(1548008755920));
            Console.WriteLine(IsFibonacci(-512));
        }

        private static bool IsFibonacci(long input)
        {
            Console.WriteLine("----------");
            long tempFibonacci;
            long lastFibonacci = 0;
            long nextFibonacci = 1;
            while (lastFibonacci < input)
            {
                Console.WriteLine($"Working {lastFibonacci}");
                tempFibonacci = lastFibonacci;
                lastFibonacci += nextFibonacci;
                nextFibonacci = tempFibonacci;
            }
            Console.WriteLine($"Final:{lastFibonacci}, Target:{input}");
            return lastFibonacci == input;
        }

    }
}
