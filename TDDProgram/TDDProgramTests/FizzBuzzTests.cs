using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDProgram;

namespace TDDProgramTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz fizzbuzz;

        public FizzBuzzTests()
        {
            fizzbuzz = new FizzBuzz();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void FizzBuzz_CanWeCreateFizzBuzz_Yes()
        {
            Assert.IsNotNull(fizzbuzz);
        }

        [TestMethod]
        public void FizzBuzz_Calculate_One_One()
        {
            Assert.AreEqual("1", fizzbuzz.Calculate(1));
        }


        [TestMethod]
        public void FizzBuzz_Calculate_Two_Two()
        {
            Assert.AreEqual("2", fizzbuzz.Calculate(2));
        }

        [TestMethod]
        public void FizzBuzz_Calculate_Three_Fizz()
        {
            Assert.AreEqual(FizzBuzz.FIZZ, fizzbuzz.Calculate(3));
        }

        [TestMethod]
        public void FizzBuzz_Calculate_Five_Buzz()
        {
            Assert.AreEqual(FizzBuzz.BUZZ, fizzbuzz.Calculate(5));
        }

        [TestMethod]
        public void FizzBuzz_Calculate_Nine_Fizz()
        {
            Assert.AreEqual(FizzBuzz.FIZZ, fizzbuzz.Calculate(9));
        }

        [TestMethod]
        public void FizzBuzz_Calculate_Fifteen_FizzBuzz()
        {
            Assert.AreEqual(FizzBuzz.FIZZ + FizzBuzz.BUZZ, fizzbuzz.Calculate(15));
        }
    }
}
