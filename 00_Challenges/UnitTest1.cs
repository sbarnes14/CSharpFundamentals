using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string super = "Supercalifragilisticexpialidocious";
            foreach (char letter in super)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                
                else 
                {
                    Console.WriteLine("not an 'i'");
                }              
            }
            Console.WriteLine(super.Length);
            int letterCount = 0;
            foreach (char letter in super)
            {
                ++letterCount;
            }
            Console.WriteLine(letterCount);












            string firstName = "Stuart";
            string lastName = "Barnes";
            int age = 24;
            
            string[] fav = { "some guys", "soccer", "pizza" };

            List<string> favorites = new List<string>();
            favorites.Add("some guys");
            favorites.Add("Soccer");
            favorites.Add("Pizza");
           // favorites.IndexOf("Soccer");


            List<DateTime> dates = new List<DateTime>();
            dates.Add(DateTime.Now);

            int add = age + 7;
            int sub = age - 7;
            int mul = age * 7;
            int quo = age / 7;
            Console.WriteLine($"{ add},{ sub},{ mul},{quo}");


            int hoursSlept = 8;

            if (hoursSlept>= 10)
            {
                Console.WriteLine("wow thats alot of sleep");
            }
            else if (hoursSlept > 8 && hoursSlept < 10)
            {
                Console.WriteLine("you should be pretty rested");
            }
            else if (hoursSlept < 4 && hoursSlept < 8)
            {
                Console.WriteLine("bummer");
            }
            else
            {
                Console.WriteLine("oh man, get some sleep!");
            }
        }
    }
}
