using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalyzer.Services
{
    public static class Utilities
    {
        /// <summary>
        /// Separates text creating words array
        /// </summary>
        /// <param name="text">Text to separate</param>
        /// <returns>String array with words</returns>
        public static string[] SeparateText(string text)
        {
            var separators = new char[] { ' ', '!', '?', '.', ',', '-', ':', '\"', '\'' };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
