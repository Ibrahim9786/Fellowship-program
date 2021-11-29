using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserUC1
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
