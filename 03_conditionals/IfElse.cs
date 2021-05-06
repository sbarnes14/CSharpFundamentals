﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }

            int hoursSpendStudying = 1;
            if (hoursSpendStudying < 15)
            {
                Console.WriteLine("Are you even trying?");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun playing video games");
            }
            else
            {
                Console.WriteLine("Get your chores done son!");
            }

            string input = "7";
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("you should be well rested");
            }
            else
            {
                Console.WriteLine("You might be tired today");
                if(totalHours < 4)
                {
                    Console.WriteLine("Yikes... Get some sleep!");
                }
            }
        }

        [TestMethod]
        public void IfElseIfStatements()
        {
            int age = 7;

            if (age > 17) 
            {
                Console.WriteLine("You're an adult!");
            }
            else
            {
                if(age > 6)
                {
                    Console.WriteLine("you're a kid");
                }
                else if(age > 0)
                {
                    Console.WriteLine("You're too young to be on this computer");
                }
                else
                {
                    Console.WriteLine("you're not even born yet");
                }
            }

            if(age < 65 && age > 18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }
            if(age == 55)
            {
                Console.WriteLine("You're a senoir citizen now");
            }
        }
    }
}
