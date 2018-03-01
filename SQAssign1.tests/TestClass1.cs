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
        static float expectedResult;
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
            expectedResult = 0; //Dummy data, to be replaced
            float actualResult = c1.CalcPremium(1, ""); //Dummy data, to be replaced
        }
        [TestCase(0, "", ExpectedResult = 0)] //Dummy data, to be replaced
        [TestCase(0, "", ExpectedResult = 0)] //Dummy data, to be replaced
        [TestCase(0, "", ExpectedResult = 0)] //Dummy data, to be replaced
        [TestCase(0, "", ExpectedResult = 0)] //Dummy data, to be replaced
        [TestCase(0, "", ExpectedResult = 0)] //Dummy data, to be replaced
        [TestCase(0, "", ExpectedResult = 0)] //Dummy data, to be replaced

        [Test(Description = "Test out of range values")]
        public static void Test3()
        {
            expectedResult = 0; //Dummy data, to be replaced
            float actualResult = c1.CalcPremium(1, "");
        }
    }
}
