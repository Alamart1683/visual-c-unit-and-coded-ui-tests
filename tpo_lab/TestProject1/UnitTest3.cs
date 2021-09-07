using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpo_lab;

namespace TestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void StringComputerTestSharp()
        {
            StringComputer stringComputer = new StringComputer();
            string testString = "123#*#321";
            Assert.AreEqual(2, stringComputer.getValueOfSymbolInString(testString, '#'));
        }

        [TestMethod]
        public void StringComputerTestStar()
        {
            StringComputer stringComputer = new StringComputer();
            string testString = "123#*#sss";
            Assert.AreEqual(1, stringComputer.getValueOfSymbolInString(testString, '*'));
        }
    }
}
