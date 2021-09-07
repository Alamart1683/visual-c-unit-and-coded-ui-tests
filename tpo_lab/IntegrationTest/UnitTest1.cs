using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpo_lab;

namespace IntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodStarValue2()
        {
            InputControl inputControl = new InputControl();
            StringExtractor stringExtractor = new StringExtractor();
            StringComputer stringComputer = new StringComputer();
            bool errorFlag1 = false;
            bool errorFlag2 = false;
            string s = "12&**&&**23e";
            string t = "aabbcc22";
            int k = 0;
            char computeChar = '*';
            if (inputControl.isModTwo(s) && inputControl.isModThree(s) && inputControl.isModFour(t))
            {
                if (inputControl.isLesserThenTwelfNubersInString(stringExtractor.getFirstHalfOfString(s)) &&
                    inputControl.isNotStringContainsLatinChars(stringExtractor.getLastQuaterOfString(t))
                    )
                {
                    k = stringComputer.getValueOfSymbolInString(stringExtractor.getSecondThirdPartOfString(s), computeChar);
                }
                else
                {
                    errorFlag1 = true;
                }
            }
            else
            {
                errorFlag2 = true;
            }
            Assert.AreEqual(2, k);
        }

        [TestMethod]
        public void TestMethodAmpersantValue2()
        {
            InputControl inputControl = new InputControl();
            StringExtractor stringExtractor = new StringExtractor();
            StringComputer stringComputer = new StringComputer();
            bool errorFlag1 = false;
            bool errorFlag2 = false;
            string s = "12&**&&**23e";
            string t = "aabbcc22";
            int k = 0;
            char computeChar = '&';
            if (inputControl.isModTwo(s) && inputControl.isModThree(s) && inputControl.isModFour(t))
            {
                if (inputControl.isLesserThenTwelfNubersInString(stringExtractor.getFirstHalfOfString(s)) &&
                    inputControl.isNotStringContainsLatinChars(stringExtractor.getLastQuaterOfString(t))
                    )
                {
                    k = stringComputer.getValueOfSymbolInString(stringExtractor.getSecondThirdPartOfString(s), computeChar);
                }
                else
                {
                    errorFlag1 = true;
                }
            }
            else
            {
                errorFlag2 = true;
            }
            Assert.AreEqual(2, k);
        }

        [TestMethod]
        public void TestMethodErrorFlag1True()
        {
            InputControl inputControl = new InputControl();
            StringExtractor stringExtractor = new StringExtractor();
            StringComputer stringComputer = new StringComputer();
            bool errorFlag1 = false;
            bool errorFlag2 = false;
            string s = "12&**&&**23e";
            string t = "aabbcca2";
            int k = 0;
            char computeChar = '*';
            if (inputControl.isModTwo(s) && inputControl.isModThree(s) && inputControl.isModFour(t))
            {
                if (inputControl.isLesserThenTwelfNubersInString(stringExtractor.getFirstHalfOfString(s)) &&
                    inputControl.isNotStringContainsLatinChars(stringExtractor.getLastQuaterOfString(t))
                    )
                {
                    k = stringComputer.getValueOfSymbolInString(stringExtractor.getSecondThirdPartOfString(s), computeChar);
                }
                else
                {
                    errorFlag1 = true;
                }
            }
            else
            {
                errorFlag2 = true;
            }
            Assert.AreEqual(true, errorFlag1);
        }

        [TestMethod]
        public void TestMethodErrorFlag2True()
        {
            InputControl inputControl = new InputControl();
            StringExtractor stringExtractor = new StringExtractor();
            StringComputer stringComputer = new StringComputer();
            bool errorFlag1 = false;
            bool errorFlag2 = false;
            string s = "12345";
            string t = "aa2";
            int k = 0;
            char computeChar = '*';
            if (inputControl.isModTwo(s) && inputControl.isModThree(s) && inputControl.isModFour(t))
            {
                if (inputControl.isLesserThenTwelfNubersInString(stringExtractor.getFirstHalfOfString(s)) &&
                    inputControl.isNotStringContainsLatinChars(stringExtractor.getLastQuaterOfString(t))
                    )
                {
                    k = stringComputer.getValueOfSymbolInString(stringExtractor.getSecondThirdPartOfString(s), computeChar);
                }
                else
                {
                    errorFlag1 = true;
                }
            }
            else
            {
                errorFlag2 = true;
            }
            Assert.AreEqual(true, errorFlag2);
        }
    }
}
