using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalyzer.Models
{
    public class AnalyzeRequest
    {
        /// <summary>
        /// Requested text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// List of analyzers' names
        /// </summary>
        public IEnumerable<string> Analyzers { get; set; }
    }
}
