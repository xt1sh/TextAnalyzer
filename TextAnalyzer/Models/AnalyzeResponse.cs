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

        public string AnalyzerName { get; set; }
        public string AdditionalMessage { get; set; }
        public string Result { get; set; }
    }
}
