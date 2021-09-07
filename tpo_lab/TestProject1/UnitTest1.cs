using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpo_lab;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InputControlTestModTwoTrue()
        {
            InputControl inputControl = new InputControl();
            string testString = "123sss";
            Assert.AreEqual(true, inputControl.isModTwo(testString));
        }

        [TestMethod]
        public void InputControlTestModTwoFalse()
        {
            InputControl inputControl = new InputControl();
            string testString = "123sss4";
            Assert.AreEqual(false, inputControl.isModTwo(testString));
        }

        [TestMethod]
        public void InputControlTestModThreeTrue()
        {
            InputControl inputControl = new InputControl();
            string testString = "123sssABc";
            Assert.AreEqual(true, inputControl.isModThree(testString));
        }

        [TestMethod]
        public void InputControlTestModThreeFalse()
        {
            InputControl inputControl = new InputControl();
            string testString = "123sssABc4";
            Assert.AreEqual(false, inputControl.isModThree(testString));
        }

        [TestMethod]
        public void InputControlTestModFourTrue()
        {
            InputControl inputControl = new InputControl();
            string testString = "123sssAB4sss";
            Assert.AreEqual(true, inputControl.isModThree(testString));
        }

        [TestMethod]
        public void InputControlTestModFourFalse()
        {
            InputControl inputControl = new InputControl();
            string testString = "123sssABc4sss";
            Assert.AreEqual(false, inputControl.isModThree(testString));
        }

        [TestMethod]
        public void InputControlTestIsLesserThen12NumbersTrue()
        {
            InputControl inputControl = new InputControl();
            string testString = "123sssABc4sss";
            Assert.AreEqual(true, inputControl.isLesserThenTwelfNubersInString(testString));
        }

        [TestMethod]
        public void InputControlTestIsLesserThen12NumbersFalse()
        {
            InputControl inputControl = new InputControl();
            string testString = "0123456789123sss";
            Assert.AreEqual(false, inputControl.isLesserThenTwelfNubersInString(testString));
        }

        [TestMethod]
        public void InputControlTestIsNotStringContainsLatinCharsTrue()
        {
            InputControl inputControl = new InputControl();
            string testString = "123456";
            Assert.AreEqual(true, inputControl.isNotStringContainsLatinChars(testString));
        }

        [TestMethod]
        public void InputControlTestIsNotStringContainsLatinCharsFalse()
        {
            InputControl inputControl = new InputControl();
            string testString = "123456s";
            Assert.AreEqual(false, inputControl.isNotStringContainsLatinChars(testString));
        }
    }
}
