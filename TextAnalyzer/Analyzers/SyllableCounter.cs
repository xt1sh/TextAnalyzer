using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyzer.Interfaces;
using TextAnalyzer.Services;

namespace TextAnalyzer.Analyzers
{
    /// <summary>
    /// Analyzer that counts syllables in every word in text and summs them
    /// </summary>
    public class SyllableCounter : IAnalyzer
    {
        public string AnalyzerName => nameof(SyllableCounter);

        public string AdditionalMessage { get; set; }

        public SyllableCounter()
        {
            AdditionalMessage = "Syllables counted";
        }

        public string AnalyzeMetric(string text)
        {
            var words = Utilities.SeparateText(text);
            var count = 0;

            foreach (var word in words)
            {
                count += CountSyllablesInWord(word);
            }

            return count.ToString();
        }

        /// <summary>
        /// Counts syllables in word
        /// </summary>
        /// <param name="word">Word to count syllables in</param>
        /// <returns>Number of syllables</returns>
        private static int CountSyllablesInWord(string word)
        {
            var processedWord = word.ToUpper().Trim();
            var vowels = new[] { 'A', 'E', 'I', 'O', 'U', 'Y' };

            var count = 0;
            bool lastWasVowel = false;

            foreach (var ch in processedWord)
            {
                if (vowels.Contains(ch))
                {
                    if (!lastWasVowel)
                        count++;
                    lastWasVowel = true;
                }
                else
                    lastWasVowel = false;
            }

            if ((processedWord.EndsWith("e") || processedWord.EndsWith("es") || processedWord.EndsWith("ed"))
                  && !processedWord.EndsWith("le"))
                count--;

            return count;
        }
    }
}
