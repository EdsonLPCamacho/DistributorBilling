using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Define the revenue values for each state
        var revenues = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        // Calculate the total revenue
        double totalRevenue = revenues.Values.Sum();

        // Display the total revenue
        Console.WriteLine($"Total Monthly Revenue: R${totalRevenue:N2}");

        // Calculate and display the percentage representation of each state
        foreach (var state in revenues)
        {
            double percentage = (state.Value / totalRevenue) * 100;
            Console.WriteLine($"{state.Key}: {percentage:N2}%");
        }
    }
}
