using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {
        //1 Access Modifier
        //2 Return Type
        //3 Method signature - includes method Name and any parameters
        //4 Body of the method - code that gets excecuted when the method is called

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting()
        {
            Random randy = new Random();
            string[] greetings = new string[] { "Hello", "hi", "sup", "yo" };
            int randomNumber = randy.Next(0, greetings.Length);
            string greeting = greetings[randomNumber];
            return greeting;
        }
    }
}
