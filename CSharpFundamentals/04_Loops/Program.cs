using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //while loop

            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total++;
            }

            Random rnd = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rnd.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

            //For loop

            string[] students = { "Tristan", "John", "Parker", "Trevor", "Izzy", "Hayden" };

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"whats up {students[i]}!");
            }

            //for each

            foreach (string student in students)
            {
                Console.WriteLine(student + "is in the class today");
            }

            string myName = "Tristan Simon Oshier";
            foreach(char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            //do while

            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            } while (iterator < 5);

            Console.ReadKey();
        }
    }
}
