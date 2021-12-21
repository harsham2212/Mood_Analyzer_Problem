using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTestCAse1
{
    public class Tests
    {
        //[Test]
        //public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        //{
        //    Mood moodAnalyser = new Mood();
        //    string expected = "Sad";
        //    string actual = moodAnalyser.AnalyzeMood("I am in Sad mood");
        //    Assert.AreEqual(expected, actual);
        //}
        //[Test]
        //public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        //{
        //    Mood moodAnalyser = new Mood();
        //    string expected = "Happy";
        //    string actual = moodAnalyser.AnalyzeMood("I am in Any mood");
        //    Assert.AreEqual(expected, actual);
        //}
        //[Test]
        //public void GivenNullMessage_WhenAnalyze_ShouldReturnHappy()
        //{
        //    Mood moodAnalyser = new Mood();
        //    string expected = "Happy";
        //    string actual = moodAnalyser.AnalyzeMood(null);
        //    Assert.AreEqual(expected, actual);
        //}
        [Test]
        public void GivenNullMood_WhenAnalyze_ShouldThrowInvalidMoodException()
        {
            try
            {
                string message = null;
                Mood mood = new Mood(message);
                string result = mood.AnalyzeMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }
        [Test]
        public void GivenEMPTYMood_WhenAnalyze_ShouldThrowInvalidMoodException()
        {
            try
            {
                string message = "";
                Mood mood = new Mood(message);
                string result = mood.AnalyzeMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}