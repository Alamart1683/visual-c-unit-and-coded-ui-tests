using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpo_lab;

namespace TestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void StringExtractorTestFirstHalf()
        {
            StringExtractor stringExtractor = new StringExtractor();
            string testString = "123sss";
            Assert.AreEqual("123", stringExtractor.getFirstHalfOfString(testString));
        }

        [TestMethod]
        public void StringExtractorTestLastQuater()
        {
            StringExtractor stringExtractor = new StringExtractor();
            string testString = "123sssQq";
            Assert.AreEqual("Qq", stringExtractor.getLastQuaterOfString(testString));
        }

        [TestMethod]
        public void StringExtractorTestSecondThirdPart()
        {
            StringExtractor stringExtractor = new StringExtractor();
            string testString = "123sssQqQ";
            Assert.AreEqual("sss", stringExtractor.getSecondThirdPartOfString(testString));
        }
    }
}
