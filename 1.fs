using System;

class Program
{
    // Tail recursive function to calculate product of odd numbers down to 1
    static int ProductOfOdds(int number, int accumulator = 1)
    {
        if (number <= 1)
            return accumulator;
        return ProductOfOdds(number - 2, accumulator * number);
    }

    static void Main()
    {
        Console.WriteLine("Product of odds from 11: " + ProductOfOdds(11));
    }
}
