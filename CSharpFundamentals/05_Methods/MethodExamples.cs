using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Tristan");
            SayHello("Izzy");

            int sum = AddTwoNumbers(7, 13);

            double doubleSum = AddTwoNumbers(7.90d, 13.65d);

            int myAge = CalculateAge(new DateTime(2000, 3, 2));
            Console.WriteLine($"My age is: {myAge}");
        }

        //1.) Access Modifier
        //2.) Return Type
        //3.) Method name

        //1    //2   //3 
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public double AddTwoNumbers(double one, double two)
        {
            return one + two;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25; // .25 gives a more accurate age due to leap years
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }


        // Notes on OOP

        // The first 5 Principles of Object-Oriented Design
        //S : Single-responsibility Principles
        //O : Open-closed Principle
        //L : Liskov substitution Principle
        //I : Interface segregation Principle
        //D : Dependency inversion Principle


        // The Four Pillars of Object-Oriented Design
        //A : Abstraction
        //P : Polymorphism
        //I : Inheritance
        //E : Encapsulation
    }
}
