using System;

namespace MoodAnalyzer
{
    public class Mood
    {
        public string AnalyzeMood(string Message)
        {
            try
            {
                if (Message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch
            {
                return "Happy";
            }
        }
    }
}

