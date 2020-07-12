using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Color = "Black";
            Console.WriteLine(firstVehicle.Color);
            firstVehicle.Make = "Cadillac";
            firstVehicle.Model = "DTS";
            firstVehicle.Mileage = 7;
            firstVehicle.Year = 2018;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            string carDetails = $"{firstVehicle.Make} {firstVehicle.Color}";
            Console.WriteLine(carDetails);

            Vehicle myVehicle = new Vehicle();
            myVehicle.Year = 2025;

            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 2015, 90000, "space grey", VehicleType.Spaceship);
        }

        [TestMethod]
        public void PersonPropertyTests()
        {
            Person firstPerson = new Person("Tristan", "Oshier", new DateTime(2000, 03, 02));
            Console.WriteLine(firstPerson.FullName);
            Console.WriteLine(firstPerson.AgeInYears);

            Person newPerson = new Person("Zuko", "FireLord", new DateTime(1990, 06, 22));
            newPerson.Transport = new Vehicle("Pontiac", "Firebird", 1989, 100123, "Red and Gold", VehicleType.Car);
            Console.WriteLine(newPerson.Transport.Model);

            Assert.AreEqual("Zuko FireLord", newPerson.FullName);

        }
    }
}
