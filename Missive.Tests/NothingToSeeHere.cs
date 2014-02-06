using System;
using System.Linq;
using System.Net.Mail;

namespace Missive.Tests
{
    /// <summary>
    /// For checking API
    /// </summary>
    //TODO: Add mocks and test
    public class NothingToSeeHere
    {
        public void CheckApiChain()
        {
            Mailer.Create()
                .From("test@gmail.com")
                .To("test@gmail.com")
                .Bcc("test@gmail.com")
                .Subject("Test Message")
                .Body("Hello world")
                .IsBodyHtml()
                .HighPriority()
                .CC("test@gmail.com")
                .Send();

            MailMessage msg = Mailer.Create()
                .From("test@gmail.com")
                .To("test@gmail.com")
                .Bcc("test@gmail.com")
                .Subject("Test Message")
                .Body("Hello world")
                .IsBodyHtml()
                .HighPriority()
                .CC("test@gmail.com")
                .GetMailMessage();
        }
    }
}
