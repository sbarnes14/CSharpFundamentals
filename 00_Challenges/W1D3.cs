using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class W1D3
    {
        [TestMethod]
        public void W1D3LoopsAndConditionals()
        {
            string super = "Supercalifragilisticexpialidocious";
            foreach (char letter in super)
            {
                if (letter == 'i')
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
        }
    }
}
