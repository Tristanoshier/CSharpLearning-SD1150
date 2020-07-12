using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userIsHungry = true;
            if(userIsHungry)
            {
                Console.WriteLine("Eat Something");
            }

            int hoursSpentStudying = 1;
            if(hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }

            bool choresAreDone = false;
            if(choresAreDone)
            {
                Console.WriteLine("Have fun playing video games");
            } else
            {
                Console.WriteLine("Do your chores");
            }

            Console.WriteLine("How many hours do you sleep?");
            string input = Console.ReadLine();
            int totalHours = int.Parse(input);

            if(totalHours >= 8)
            {
                Console.WriteLine("Congrats. You are living the dream");
            } else
            {
                Console.WriteLine($"{totalHours} is not enough sleep!");
                if(totalHours < 3)
                {
                    Console.WriteLine("Thats rough buddy");
                }
            }


            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput); //This is the same as int.Parse();

            if(age > 17)
            {
                Console.WriteLine("Congrats on being an adult");
            }
            else
            {
                if(age > 6)
                {
                    Console.WriteLine("You are a kiddo");
                }
                else if (age > 0)
                {
                    Console.WriteLine("You are a baby");
                } else
                {
                    Console.WriteLine("You are not even born");
                }
            }

            if(age > 65 || age < 18)
            {
                Console.WriteLine("You are in the worst years of your life");
            }
        }
    }
}
