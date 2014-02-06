using System;
using System.Collections.Generic;
using System.Linq;

namespace Missive.Templates.Simple
{
    public class MailTemplateParameters : List<MailTemplateParameter>
    {
        public void Add(string parameter, string value)
        {
            this.Add(new MailTemplateParameter() { Parameter = parameter, Value = value });
        }
    }
}
