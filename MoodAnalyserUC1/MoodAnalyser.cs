using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserUC1
{
    public class MoodAnalyser
    {
        public string GetMood(string mood)
        {
            return string.Concat("I", " ", "am", " ",  "in", " " + mood, " ", "mood");
        }
    }
}
