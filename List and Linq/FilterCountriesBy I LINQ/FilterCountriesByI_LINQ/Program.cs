using System;
using System.Collections.Generic;
using System.Linq;

internal class FilterCountriesByI_LINQ
{
    static void Main(string[] args)
    {
        List<string> countries = new List<string>
        {
            "Argentina",
            "Australia",
            "Brazil",
            "Canada",
            "Egypt",
            "France",
            "India",
            "Italy",
            "Mexico",
            "Netherlands",
            "South Africa",
            "United States",
        };


        IEnumerable<string> query = countries.Where(country => country.StartsWith("I", StringComparison.OrdinalIgnoreCase));

        // The StartsWith("I", StringComparison.OrdinalIgnoreCase) method checks if the country starts with the letter "I" or "i", ignoring the case.
        //The StringComparison.OrdinalIgnoreCase makes the comparison case -insensitive, so both "I" and "i" will match.

        foreach (string country in query)
        {
            Console.WriteLine(country);
        }
    }
}