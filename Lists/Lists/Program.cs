using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        string[] characters = new string[]
        {
            "Eminem", "Mario", "Steve", "Stanley", "Sonic", "BT-7274", "Donkey Kong", "Elliot", "Luigi", "Kratos",
            "Liquid Snake", "Master Chief", "Astro"
        };

        List<string> characterList = new List<string>();
        characterList.Add("Yoshi"); 

        foreach (string character in characters)
        {

            characterList.Add(character);

        }

        Console.WriteLine("Characters (for-loop):");
        for (int i = 0; i < characterList.Count; i++) 
        {


            Console.WriteLine($"- {characterList[i]}");
        }

        Console.WriteLine("\nCharacters (foreach-loop):");
        foreach (string character in characterList)
        {
            Console.WriteLine($"- {character}");
        }
    }
}
