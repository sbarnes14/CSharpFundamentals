using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);

                total = total + 1;
            }

            int someCount = 0;
            bool keepLooping = true;

            while (keepLooping)
            {
                if (someCount <= 100)
                {
                    Console.Write(" " + someCount);
                    someCount++; //same as someCount = someCount + 1;
                }
                else
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 28;

            //1 Starting Point
            //2 Condition
            //3 What to do after each loop
            //Body of the lop - what gets excecuted each loop


            //1         //3             //3
            for (int i = 0; i < studentCount; i++)
            {   //4
                Console.WriteLine(i);
            }
            int e = 0;
            while (e < studentCount)
            {
                Console.WriteLine(e++);
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Aaron", "alexandro", "Andrew", "Ben", "Chris" };

            foreach (string student in students)
            {
                Console.WriteLine(students + "is a student in this class");
            }

            string myName = "Stuart Barnes";

            foreach (char letter in myName)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 5;
            do
            {
                Console.WriteLine("hello");
                Console.WriteLine(iterator);
                iterator++;
            }
            while (iterator < 5);
        }
    }
}
