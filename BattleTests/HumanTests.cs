using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim.Characters;
using BattleSim.Utility;

namespace BattleTests
{
    /// <summary>
    /// Summary description for HumanTests
    /// </summary>
    [TestClass]
    public class HumanTests
    {
        public HumanTests()
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

        //[TestMethod]
        //public void TestAttack()
        //{
        //    Knight cedric = new Knight("Sir Cedric");
        //    AttackResult result;
        //    string message;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        result = cedric.Attack(cedric);
        //        if (result.AttackHit)
        //        {
        //            if (result.Critical)
        //            {
        //                message = "Critical hit for " + result.DamageDone;
        //            }
        //            message = "Standard hit for " + result.DamageDone;
        //        }
        //        else
        //        {
        //            message = "Big wiff.";
        //        }
        //        Console.WriteLine(message);
        //    }

        //}
    }
}
