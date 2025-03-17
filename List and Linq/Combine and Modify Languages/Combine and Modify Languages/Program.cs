using System;
using System.Collections.Generic;

namespace Combine_and_Modify_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> progLangsOne = new List<string>() { "C#", "JavaScript", "Kotlin", "Python" };
            List<string> progLangsTwo = new List<string>() { "C++", "Go", "Swift", "TypeScript" };

            progLangsTwo.AddRange(progLangsOne);

            List<string> allProgLangs = progLangsTwo;

            allProgLangs.Add("Rust");
            allProgLangs.Remove("Swift");

            foreach (string s in allProgLangs)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();

        }
    }
}