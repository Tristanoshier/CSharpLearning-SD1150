using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises01
{
    class Program
    {
        enum Drinks { Water, Soda, Beer, Wine };
        static void Main(string[] args)
        {
            // 01 - Types

            // Value Types
            string name;
            string order;
            double total;
            double tip;
            bool happyWithService;

            name = "Tristan";
            order = "Cheese Burger";
            total = 13.89;
            tip = 4.00;
            happyWithService = true;
            Drinks drink = Drinks.Soda; 
            

            Console.WriteLine($"name: {name}");
            Console.WriteLine($"drink: {drink}");
            Console.WriteLine($"order: {order}");
            Console.WriteLine($"total: {total}");
            Console.WriteLine($"tip: {tip}");
            Console.WriteLine($"Was customer satisfied: {happyWithService}");


            //Reference Type
            string color = "gold";
            string myName = "Tristan";

            string welcomeMessage = string.Format("Welcome to Amazon, {0}. You are currently a {1} member so your package will take 3 - 5 business days to arrive.", myName, color);
            string spamMessage = string.Format("{0}, Please ignore this email and do not respond. This is just verifying that you are a {1} member.", myName, color);
            string randomSentence = string.Format("{0} You are a {1} member. Congrats!", myName, color);

            Console.WriteLine(welcomeMessage);
            Console.WriteLine(spamMessage);
            Console.WriteLine(randomSentence);

            //Interpolation
            string cheese = "string cheese";
            string pasta = "mac and cheese";
            string beans = "kidney beans";

            string randomSentenceTwo = $"The following recipe will contain {cheese}, {pasta}, and {beans}.";
            Console.WriteLine(randomSentenceTwo);

            //Concatenate
            string variable = "Hello";

            string concatSentence = variable + " world, and " + variable + " class. Welcome to the gold badge.";
            string interpolationSentence = $"{variable} world, and {variable} class. Welcome to the gold badge.";
            string compositeSentence = string.Format("{0} world, and {0} class. Welcome to the gold badge.", variable);

            Console.WriteLine(concatSentence);
            Console.WriteLine(interpolationSentence);
            Console.WriteLine(compositeSentence);

            //Collections
            char[] characterFavs = { 'A', 'B', 'C', 'D', 'E' };

            Console.WriteLine(characterFavs[2]);

            List<string> Fruits = new List<string>();
            Fruits.AddRange(new List<string>() {"apple", "grapes", "cherries", "strawberries", "blackberries", "raspberries"});
            Fruits.Sort();
            foreach(string fruit in Fruits)
            {
                Console.WriteLine(fruit);
            }

            //Operators
            int a = 42;
            int b = 5;

            Console.WriteLine(a * b);
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);

            int day = 24;


            Console.ReadKey();

        }
    }
}
