using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAssign1.tests
{
    [TestFixture]
    public class TestClass1
    {
        static float expectedResult, actualResult;
        static Class1 c1;

        [SetUp]
        public static void Init()
        {
            c1 = new Class1();
        }

        [Test(Description = "Test object is not null")]
        public void Test1()
        {
            Assert.NotNull(c1, "Object not created");
        }

        [Test(Description = "Test premium")]
        public static void Test2()
        {
            expectedResult = 5;
            c1.setProperties(18, "female"); // setProperties method, so Class1 can be used with both Fitnesse and Nunit
            float actualResult = c1.CalcPremium();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(17, "female", ExpectedResult = 0)]
        [TestCase(50, "female", ExpectedResult = 0.375)]
        [TestCase(35, "male", ExpectedResult = 6)]
        [TestCase(36, "male", ExpectedResult = 5)]
        [TestCase(9, "male", ExpectedResult = 0)]
        [TestCase(31, "other", ExpectedResult = 0)]

        public float Test3(int age, string gen)
        {
            c1.setProperties(age, gen); // setProperties method, so Class1 can be used with both Fitnesse and Nunit
            return actualResult = c1.CalcPremium();
        }
    }
}
