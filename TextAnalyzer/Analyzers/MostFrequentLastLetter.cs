using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyzer.Interfaces;
using TextAnalyzer.Services;

namespace TextAnalyzer.Analyzers
{
    /// <summary>
    /// Analyzer counts the most frequent letter that is located in the end of the words
    /// </summary>
    public class MostFrequentLastLetter : IAnalyzer
    {
        public string AnalyzerName => nameof(MostFrequentLastLetter);

        public string AdditionalMessage { get; set; }

        public MostFrequentLastLetter()
        {
            AdditionalMessage = "The most frequent letter in the end of words";
        }

        public string AnalyzeMetric(string text)
        {
            try
            {
                var words = Utilities.SeparateText(text.ToUpper());
                var letters = words.Select(word => word.Substring(word.Length - 1));

                return letters.GroupBy(l => l).OrderByDescending(l => l.Count()).First().Key;
            }
            catch
            {
                return "";
            }
        }
    }
}
