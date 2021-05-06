using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void VehiclePropertiesTest()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 124312;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
        }

        [TestMethod]
        public void IndicatorVehicleTests()
        {
            
            Indicator indicator = new Indicator();
            //Cannot be set outside of lass, private set 
            //indicator.isFlashing = true;
            Console.WriteLine(indicator.isFlashing);
            indicator.TurnOn();
            Console.WriteLine(indicator.isFlashing);
        }

        [TestMethod]
        public void VehicleConstructorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan";
            car.Model = "Stagea";
            car.Mileage = 50000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model);

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy",100000, VehicleType.Plane);
            Console.WriteLine($" I rode on a spaceship, it was the {rocket.Make}");

            rocket.Model = "Constellation";
            Console.WriteLine($"That ship is a {rocket.Model}");
        }

        //Greeter
        [TestMethod]
        public void GreeterMethodTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("chad");

            List<string> students = new List<string>();
            students.Add("Hannah");
            students.Add("Kevin");
            students.Add("Bob");
            students.Add("Stuart");
            students.Add("Geoff");
            students.Add("Andy");

            foreach(string student in students)
            {
                greeterInstance.SayHello(student);
            }


            string greeting = greeterInstance.GetRandomGreeting();
            Console.WriteLine(greeting);
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            double sum = calculatorInstance.GetSum(3.6, 100.2);
            Console.WriteLine(sum);

            int age = calculatorInstance.CalculateAge(new DateTime(1997, 03, 17));
            Console.WriteLine(age);
        }

        //Person
        [TestMethod]
        public void PersonTest()
        {
            Person person = new Person("Stuart", "Barnes", new DateTime(1997,03,17));
            Console.WriteLine(person.FirstName + " " + person.LastName);
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.Age);

            Person stuart = new Person();
            stuart.FirstName = "Stuart";
            stuart.DateOfBirth = new DateTime(2001, 08, 26);
            Console.WriteLine(stuart.FullName);
            Console.WriteLine(stuart.Age);

            // Single line instance if new'ing up a person
            Person andrew = new Person()
            {
                FirstName = "Andrew",
                LastName = "Torr",
                DateOfBirth = new DateTime(1950, 12, 25)
            };

            //Asserting with a test that these two are equal 
            Assert.AreEqual("Stuart", stuart.FirstName);
            //Asserting that these are pnot equal 
            //Assert.AreNotEqual("stuart", stuart.FirstName);
            //Commented out because it fails as expected 
        }

        Person _person = new Person("Luke", "Skywalker", new DateTime(200, 01, 31));

        [TestMethod]
        public void PersonTransportTest()
        {
            _person.Transport = new Vehicle("X-Wing", "Starship", 100, VehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make}{_person.Transport.Model}");

            _person.Transport.Make = "T16 Skyhopper";
            Console.WriteLine(_person.Transport.Make);

            Person blank = new Person();
            Console.WriteLine($"Fullname: {blank.Transport}");

            Console.WriteLine($"Unset class:{blank.Transport}");
            Console.WriteLine($"Unset struct: {blank.DateOfBirth}");
            Console.WriteLine($"Age: {blank.Age}");
        }
    }
}
