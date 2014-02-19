using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missive.Templates.Razor
{
    public static class RazorTemplate
    {
        /// <summary>
        /// Applies a model to a razor template.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">Model</param>
        /// <param name="template">Razor Template</param>
        /// <returns></returns>
        public static string ToEmailBody<T>(this T model, string template)
        {
            return RazorEngine.Razor.Parse(template, model);
        }
    }
}