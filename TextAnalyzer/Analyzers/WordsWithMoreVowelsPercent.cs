using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyzer.Interfaces;
using TextAnalyzer.Services;

namespace TextAnalyzer.Analyzers
{
    /// <summary>
    /// Analyzer that calculates the percentage of words that have more vowels than consonants
    /// </summary>
    public class WordsWithMoreVowelsPercent : IAnalyzer
    {
        public string AnalyzerName => nameof(WordsWithMoreVowelsPercent);

        public string AdditionalMessage { get; set; }

        public WordsWithMoreVowelsPercent()
        {
            AdditionalMessage = "The percentage of words that have more vowels than consonants";
        }

        public string AnalyzeMetric(string text)
        {
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            var words = Utilities.SeparateText(text);

            var wordsWithVowelsCount = 0;

            foreach (var word in words)
            {
                var vowelsCount = word.ToUpper().Where(ch => vowels.Contains(ch)).Count();

                if (vowelsCount > word.Count() - vowelsCount)
                    wordsWithVowelsCount++;
            }

            if (words.Count() == 0)
                return "0";

            return ((double)wordsWithVowelsCount / words.Count() * 100).ToString();
        }
    }
}
