using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyzer.Analyzers;
using TextAnalyzer.Interfaces;

namespace TextAnalyzer.Services
{
    public static class ServiceConfigurations
    {
        /// <summary>
        /// Adds analyzers to DI
        /// </summary>
        /// <param name="services"></param>
        public static void AddAnalyzers(this IServiceCollection services)
        {
            // Add new analyzers here to make them work

            services.AddTransient<IAnalyzer, SyllableCounter>();
        }
    }
}
