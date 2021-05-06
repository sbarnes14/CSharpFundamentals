using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Stuart";
            bool isEqual = (age == 41); //the value of isEqual deoends on the comparison in the ()

            bool userIsKevin = userName == "Kevin";
            
            Console.WriteLine(userIsKevin);
            Console.WriteLine(isEqual);

            bool isNotEqual = age != 23;
            Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = (firstList == secondList);
            Console.WriteLine(listsAreEqual);

            bool isGreatThan = age > 26;
            Console.WriteLine(isGreatThan);

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan);

            bool isGreaterOrEqual = age >= 41;
            Console.WriteLine(isGreatThan);

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = (isTrue == true && isFalse == false);

            bool anotherAndValue = (age == 25 && userName == "Stuart");
            bool orValue = (age == 25 || userName == "userIsKevin");
        }
    }
}
