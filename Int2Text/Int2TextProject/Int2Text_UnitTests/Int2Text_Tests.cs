using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Int2TextProject;

namespace Int2Text_UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Int2Text_Tests
    {
        public Int2Text_Tests()
        {
            //
            // TODO: Add constructor logic here
            //
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
        public void Int2Text_Instantiate_Test()
        {
            Int2Text i2t = new Int2Text();
            Assert.IsTrue(i2t != null);
        }

        [TestMethod]
        public void Int2Text_NumbersBelowTwenty_Test()
        {
            Int2Text i2t = new Int2Text();
            Assert.AreEqual("Zero", i2t.Convert(0));
            Assert.AreEqual("One", i2t.Convert(1));
            Assert.AreEqual("Two", i2t.Convert(2));
            Assert.AreEqual("Three", i2t.Convert(3));
            Assert.AreEqual("Ten", i2t.Convert(10));
        }

        [TestMethod]
        public void Int2Text_NumbersFromTwentyToNinetyByTens_Test()
        {
            Int2Text i2t = new Int2Text();
            Assert.AreEqual("Twenty", i2t.Convert(20));
            Assert.AreEqual("Fifty", i2t.Convert(50));
            Assert.AreEqual("Seventy", i2t.Convert(70));
            Assert.AreEqual("Ninety", i2t.Convert(90));
            Assert.AreEqual("Ninety-Eight", i2t.Convert(98));
        }

        [TestMethod]
        public void Int2Text_NumbersFrom100Up_Test()
        {
            Int2Text i2t = new Int2Text();
            Assert.AreEqual("One Hundred", i2t.Convert(100));
            Assert.AreEqual("One Hundred One", i2t.Convert(101));
            Assert.AreEqual("One Hundred Twenty", i2t.Convert(120));
            Assert.AreEqual("One Hundred Ninety", i2t.Convert(190));
            Assert.AreEqual("One Hundred Ninety-Eight", i2t.Convert(198));
            Assert.AreEqual("One Hundred Ninety-Nine", i2t.Convert(199));

            Assert.AreEqual("Two Hundred One", i2t.Convert(201));

            Assert.AreEqual("Nine Hundred Ninety-Nine", i2t.Convert(999));
        }

        [TestMethod]
        public void Int2Text_NumbersFrom1000Up_Test()
        {
            Int2Text i2t = new Int2Text();
            Assert.AreEqual("One Thousand", i2t.Convert(1000));
            Assert.AreEqual("One Thousand One", i2t.Convert(1001));
            Assert.AreEqual("Two Thousand One", i2t.Convert(2001));
            Assert.AreEqual("Two Thousand One Hundred One", i2t.Convert(2101));
            Assert.AreEqual("Nineteen Thousand", i2t.Convert(19000));
            Assert.AreEqual("Twenty Thousand", i2t.Convert(20000));
            Assert.AreEqual("One Hundred Twenty Thousand", i2t.Convert(120000));
        }

        [TestMethod]
        public void Int2Text_NumbersFromOneMillionUp_Test()
        {
            Int2Text i2t = new Int2Text();
            Assert.AreEqual("One Million", i2t.Convert(1000000));
            Assert.AreEqual("One Billion", i2t.Convert(1000000000));

            Assert.AreEqual("Nine Hundred Ninety-Nine Million Nine Hundred Ninety-Nine Thousand Nine Hundred Ninety-Nine", i2t.Convert(999999999));
        }
    }
}
