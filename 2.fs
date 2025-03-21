using System;
using System.Linq;

internal class Program
{
    private static void Main()
    {
        string[] names = { " Charles", "Babbage  ", "  Von Neumann  ", "  Dennis Ritchie  " };
        var trimmedNames = names.Select(name => name.Trim()).ToArray();

        Console.WriteLine("Trimmed names: ");
        foreach (var name in trimmedNames)
            Console.WriteLine(name);
    }
}
