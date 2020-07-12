using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 7;
            int a = 11;

            //Addition
            int sum = a + b;
            Console.WriteLine(sum);

            //subtraction
            int difference = a - b;
            Console.WriteLine(difference);

            //multiplication
            int product = a * b;
            Console.WriteLine(product);

            //division
            int quotient = a / b;
            Console.WriteLine(quotient);

            //Remainder
            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1842, 1, 1);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan);

            // Comparison Operators
            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter your name");
            string username = Console.ReadLine();
            bool equals = age == 41;
            bool userIsFrank = username == "Frank";
            Console.WriteLine("User is 41: " + equals);
            Console.WriteLine("User is Frank: " + userIsFrank);

            bool notEqual = age != 113;
            bool userIsNotJustin = username != "Justin";
            Console.WriteLine($"User is not 113: {notEqual}");
            Console.WriteLine($"User is not Justin: {userIsNotJustin}");

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);
            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 55;
            bool lessThan = age < 12;
            bool lessThanOrEqual = age >= 55;

            bool orValue = equals || lessThan;
            bool trueOrTrue = true || true;
            bool trueOrFalse = true || false;
            bool falseOrTrue = false || true;
            bool falseOrFalse = false || false;

            bool andValue = greaterThan && orValue;
            bool trueAndTrue = true && true;
            bool trueAndFalse = true && false;
            bool falseAndTrue = false && true;
            bool falseAndFalse = false && false;

            int x= 3;
            bool test = x < 44 && x > 10;


            Console.ReadKey();
        }
    }
}
