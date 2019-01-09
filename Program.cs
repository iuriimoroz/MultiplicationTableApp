using System;

namespace MultiplicationTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int factor;
            int multiplicator;
            int product;

            for(factor = 1; factor <= 10; factor++)
            {
                for (multiplicator = 1; multiplicator <= 10; multiplicator++)
                {
                    product = factor * multiplicator;
                    Console.WriteLine($"{factor} * {multiplicator} = {product}");
                }
                Console.WriteLine();
            }
 
            Console.ReadKey();
        }
    }
}
