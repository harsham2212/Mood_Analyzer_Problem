using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTestCase
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Mood Analyze = new Mood();
            string expected = "Sad";
            string actual = Analyze.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod2()
        {
            Mood analyzer = new Mood();
            string expected = "Happy";
            string actual = analyzer.AnalyzeMood(" I am in any mood");
            Assert.AreEqual(expected, actual);
        }
    }
}
