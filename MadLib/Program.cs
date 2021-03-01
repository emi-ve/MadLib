using System;

namespace MadLib
{ 
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program: MadLibs - C# practice
            Author: Em Vi
            */


            // Let the user know that the program is starting:
            Console.WriteLine("MadLibs game is started");

            // Give the Mad Lib a title:
            string title = "Mad Libz";
            Console.WriteLine(title);

            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            // ask for a verb
            Console.WriteLine("Enter a verb:");
            string verb = Console.ReadLine();

            // ask for Adjectives
            Console.WriteLine("Enter an Adjective:");
            string adj1 = Console.ReadLine();
            Console.WriteLine("Enter a 2nd Adjective:");
            string adj2 = Console.ReadLine();
            Console.WriteLine("Enter a 3rd Adjective:");
            string adj3 = Console.ReadLine();

            // ask for nouns
            Console.WriteLine("Enter a noun:");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Enter a 2nd noun:");
            string noun2 = Console.ReadLine();

            // ask more questions
            Console.WriteLine("Enter a type of animal:");
            string animal = Console.ReadLine();
            Console.WriteLine("Enter a type of food:");
            string food = Console.ReadLine();
            Console.WriteLine("Enter a type of fruit:");
            string fruit = Console.ReadLine();
            Console.WriteLine("Enter a name of a superhero:");
            string hero = Console.ReadLine();
            Console.WriteLine("Enter a name of a country:");
            string country = Console.ReadLine();
            Console.WriteLine("Enter a type of dessert:");
            string dessert = Console.ReadLine();
            Console.WriteLine("Enter a year(ex:1999):");
            string year = Console.ReadLine();



            // The template for the story:

            string story = ($"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.");


            // Print the story:

            Console.WriteLine(story);

        }
    }
}
