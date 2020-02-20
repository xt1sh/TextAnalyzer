using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TextAnalyzer.Interfaces;
using TextAnalyzer.Models;

namespace TextAnalyzer.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class AnalyzeController : ControllerBase
    {
        private readonly IEnumerable<IAnalyzer> _analyzers;

        public AnalyzeController(IEnumerable<IAnalyzer> analyzers)
        {
            _analyzers = analyzers;
        }

        [HttpPost]
        public IActionResult AnalyzeText(AnalyzeRequest request)
        {
            try
            {
                if (request.Analyzers is null || request.Analyzers.Count() == 0)
                    return BadRequest(new { Message = "Please choose analyzers" });

                var response = new List<AnalyzeResponse>();

                foreach (var analyzerName in request.Analyzers)
                {
                    var analyzer = _analyzers.FirstOrDefault(a => a.AnalyzerName.ToUpper() == analyzerName.ToUpper());

                    if (analyzer != null)
                    {
                        var result = analyzer.AnalyzeMetric(request.Text);
                        response.Add(new AnalyzeResponse(analyzer.AnalyzerName, analyzer.AdditionalMessage, result));
                    }
                }

                return Ok(response);
            }
            catch(Exception e)
            {
                // log here
                throw new Exception("Oops. Something went wrong");
            }
        }
    }
}