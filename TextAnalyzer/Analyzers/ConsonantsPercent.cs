using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyzer.Interfaces;

namespace TextAnalyzer.Analyzers
{
    /// <summary>
    /// Analyzer that divides number of consonants by number of vovels
    /// If there is no vowel returns the number of consonants
    /// </summary>
    public class ConsonantsPercent : IAnalyzer
    {
        public string AnalyzerName => nameof(ConsonantsPercent);

        public string AdditionalMessage { get; set; }

        public ConsonantsPercent()
        {
            AdditionalMessage = "Number of consonants divided by number of vowels";
        }

        public string AnalyzeMetric(string text)
        {
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            var vowelsCount = 0;
            var consonantsCount = 0;

            foreach (var ch in text)
            {
                if (char.IsLetter(ch))
                {
                    if (vowels.Contains(char.ToUpper(ch)))
                        vowelsCount++;
                    else
                        consonantsCount++;
                }
            }

            if (vowelsCount == 0)
                consonantsCount.ToString();

            return ((double)consonantsCount / vowelsCount).ToString();
        }
    }
}
