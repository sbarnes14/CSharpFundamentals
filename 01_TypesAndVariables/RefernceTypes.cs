using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class RefernceTypes
    {
        private bool interpolatedStrings;

        [TestMethod]
        public void Strings()
        {
            string firstName = "Stuart";
            string lastName = "Barnes";

            //Concatenation
            string concatenatedFullName = firstName + ' ' + lastName;
            Console.WriteLine(concatenatedFullName);

            //compositing
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullName);

            //interpolation
            string interpolatedFullName = $"{firstName} \"is cool\"{lastName} can do cool things";
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void collections()
        {
            //Arrays
            string stringExample = "Hello Wolrd";

            string[] stringArray = { "Hello", "World", "why", "is it", "always", stringExample, "?" };

            string interpolatdedStrings = $"{stringArray[2]} {stringArray[5]}";
            Console.WriteLine(interpolatdedStrings);

            string firstString= stringArray[0];

            //Lists
            List<string> listOfStrings = new List<string>(stringArray);
            List<int> listOfIntergers = new List<int>();
            
            listOfStrings.Add("Hello");
            listOfIntergers.Add(23);
            listOfStrings.Add("world");
            Console.WriteLine(listOfIntergers[0]);
            Console.WriteLine(listOfStrings[1]);
            listOfStrings.Remove(listOfStrings[0]);
            Console.WriteLine(listOfStrings[0]);

            //queues
            Queue<String> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");
            firstInFirstOut.Enqueue("I'm last");

            string whosFirst = firstInFirstOut.Peek();
            Console.WriteLine(whosFirst);
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            string whosFirstNow = firstInFirstOut.Peek();
            Console.WriteLine(whosFirstNow);

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(001, "EFA Office");

            string badgeDoor = keyAndValue[001];

            Console.WriteLine(badgeDoor);

            //SortedList
            //HashSet
            //Stack
        }
    }
}
