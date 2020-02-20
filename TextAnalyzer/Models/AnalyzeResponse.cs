using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalyzer.Models
{
    public class AnalyzeResponse
    {
        public AnalyzeResponse(string analyzerName, string additionalMessage, string result)
        {
            AnalyzerName = analyzerName;
            AdditionalMessage = additionalMessage;
            Result = result;
        }
        /// <summary>
        /// Name of the analyzer that was used
        /// </summary>
        public string AnalyzerName { get; set; }
        /// <summary>
        /// Analyzer's additional message
        /// </summary>
        public string AdditionalMessage { get; set; }
        /// <summary>
        /// Result that was returned by AnalyzeMetric method
        /// </summary>
        public string Result { get; set; }
    }
}
