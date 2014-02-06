using System;
using System.IO;
using System.Linq;

namespace Missive.Templates.Simple
{
    public class MailTemplate
    {
        public MailTemplate(string path)
        {
            this.ReadTemplate(path);
        }

        public string Body { get; set; }

        public void ReadTemplate(string path)
        {
            StreamReader sr;
            sr = File.OpenText(path);
            Body = sr.ReadToEnd();
        }

        public void Set(string parameter, string value)
        {
            Body = Body.Replace(parameter, value);
        }

        public void Set(MailTemplateParameters mailParameters)
        {
            foreach (var item in mailParameters)
            {
                Body = Body.Replace(item.Parameter, item.Value);
            }
        }
    }
}
