using _08_Interfaces.Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            Banana banana1 = new Banana();
            // cant' create an interface object
            //IFruit banana = new IFruit();

            // var is like a wildcard argument
            var output = banana.peel();
            Console.WriteLine(output);

            Console.WriteLine("The banana is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            Orange orange = new Orange();

            // Var allows differnt fruits using the IFruit interface to exist together
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Orange(),
                orange
            };
            // Orange exclusive methods still accessible outside the IFruit collection
            orange.Squeeze();

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.peel());
                //No mlonger accessible once in a collection
                //fruit.Squeeze

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();

            string output = GetFruitName(grape);

            Console.WriteLine(output);
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");
            foreach(var fruit in fruitSalad)
            {
                //Checking it's of type orange, casting it as an orange 
                //Pattern matching
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("It's a peeled orange");
                        // regain orange exclusive propertiers
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                    {
                        Console.WriteLine("It's an orange");
                    }
                }

                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("It's a grape");
                    // without pattern matching, cast is necessary
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("It's a peeled banana");
                }
                else
                {
                    Console.WriteLine("It's a banana");
                }
            }

        }
    }
}
