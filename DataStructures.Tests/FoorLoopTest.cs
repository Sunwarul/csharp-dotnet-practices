using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DataStructures.Tests
{
    [TestClass]
    public class FoorLoopTest
    {
        private string _consoleOutput;

        [TestMethod]
        public void TestForLoop1To10()
        {
            _consoleOutput =  ForLoop.Looper(1, 5, 1);
            Assert.AreEqual("1 2 3 4 5 ", _consoleOutput);
        }
    }
}
