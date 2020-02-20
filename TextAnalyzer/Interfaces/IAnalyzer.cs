using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalyzer.Interfaces
{
    public interface IAnalyzer
    {
        #region props

        /// <summary>
        /// Name of analyzer that is inherited
        /// </summary>
        string AnalyzerName { get; }

        /// <summary>
        /// Message that consists of additional analyzer information
        /// </summary>
        string AdditionalMessage { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// Analyzes text for specific metric and returns response after analyzation
        /// </summary>
        /// <param name="text">Text to analyze</param>
        /// <returns>Analyzer response</returns>
        string AnalyzeMetric(string text);

        #endregion
    }
}
