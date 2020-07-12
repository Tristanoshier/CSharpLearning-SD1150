using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldTestCorrectly()
        {
            Person martha = new Person
            {
                PhoneNumber = "123-2123"
            };

            Customer bob = new Customer
            { 
                PhoneNumber = "123-1234"
            };

            SalaryEmployee ted = new SalaryEmployee
            { 
                PhoneNumber = "767-2321",
                Salary = 120000,
                HireDate = new DateTime(1304, 01, 01)
            };
            Console.WriteLine(ted.YearsWithCompany);
        }

        [TestMethod]
        public void CustomerIsPremium_ShouldGetCorrectBool()
        {
            Customer firstCustomer = new Customer();
            firstCustomer.IsPremium = true;

            Person newPerson = new Person();
            Console.WriteLine(newPerson.GetType());

            Console.WriteLine(firstCustomer.GetType());
            Assert.IsTrue(firstCustomer.IsPremium);
        }

        [TestMethod]
        public void EmployeeTests()
        {
            Employee javis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            tony.HoursWorked = 55;
            tony.HourlyWage = 9003;
            pepper.Salary = 200000;

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(javis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper);


            tony.SetFirstName("Tristan");
            tony.SetLastName("Oshier");
            Console.WriteLine(tony.Name);

            foreach(Employee worker in allEmployees)
            {
                if(worker.GetType() == typeof(SalaryEmployee))
                {
                    //Casts worker into a Salary Employee to give access to Salary
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    Console.WriteLine($"This is a salary employee that makes {sEmployee.Salary} a year");
                }
                //This is the same things as the if above, this casts the worker to a HourlyEmployee for you
                else if(worker is HourlyEmployee hourlyWorker) // pattern matching
                {
                    //HourlyEmployee hEmployee = (HourlyEmployee)hourlyWorker;
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }
        }
    }
}
