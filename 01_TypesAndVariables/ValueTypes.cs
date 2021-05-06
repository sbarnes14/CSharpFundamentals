using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true;

                bool isDeclaredAndInitalized = false;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char numberCharacter = '7';
            char symbol = '?';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767;
            Int16 anotherShort = 32765;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.564945683218674632186425841f;
            double doubleExample = 1.65498165489564872135761261d;
            decimal decimalExample = 1.6549816548965465786468781m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum pastryType { cake, cuocake, eclaire, danish, canoli}

        [TestMethod]
        public void Enum()
        {
            pastryType myPastry = pastryType.eclaire;
            pastryType anotherPasrty = pastryType.eclaire;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime Today = DateTime.Today;
            Console.WriteLine(Today);
            Console.WriteLine(DateTime.Now);
            DateTime birthday = new DateTime(1997, 17, 03);

            TimeSpan age = Today - birthday;
            int ageInDays = age.Days;

            Console.WriteLine(ageInDays / 365);
        }
    }
}
