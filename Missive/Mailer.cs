using System;
using System.Linq;
using System.Net.Mail;

namespace Missive
{
    public class Mailer
    {
        private readonly MailMessage message;

        public Mailer()
        {
            this.message = new MailMessage();
            this.message.IsBodyHtml = true;
        }

        /// <summary>
        /// Begins a new Mailer chain.
        /// End the chain by using the .Send() or .GetMailMessage methods
        /// </summary>
        /// <returns>Mailer</returns>
        public static Mailer Create()
        {
            return new Mailer();
        }

        /// <summary>
        /// Sets the From address and alias
        /// </summary>
        /// <param name="from">From email address</param>
        /// <param name="displayName">From display name or alias</param>
        /// <returns>Mailer</returns>
        public Mailer From(string from, string displayName = "")
        {
            displayName = string.IsNullOrWhiteSpace(displayName) ? from : displayName;
            this.message.From = new MailAddress(from, displayName);
            return this;
        }

        /// <summary>
        /// Adds a To email address to the message
        /// </summary>
        /// <param name="addresses">To email address</param>
        /// <returns>Mailer</returns>
        public Mailer To(string addresses)
        {
            this.message.To.Add(addresses);
            return this;
        }

        /// <summary>
        /// Adds a CC email address to the message
        /// </summary>
        /// <param name="addresses">CC email address</param>
        /// <returns>Mailer</returns>
        public Mailer CC(string addresses)
        {
            this.message.CC.Add(addresses);
            return this;
        }

        /// <summary>
        /// Adds a Bcc email address to the message
        /// </summary>
        /// <param name="addresses">Bcc email address</param>
        /// <returns>Mailer</returns>
        public Mailer Bcc(string addresses)
        {
            this.message.Bcc.Add(addresses);
            return this;
        }

        /// <summary>
        /// Sets the subject line for the message
        /// </summary>
        /// <param name="subject">The subject</param>
        /// <returns>Mailer</returns>
        public Mailer Subject(string subject)
        {
            this.message.Subject = subject;
            return this;
        }

        /// <summary>
        /// Indicates if the message body is HTML (default = true)
        /// </summary>
        /// <param name="isBodyHtml">bool</param>
        /// <returns>Mailer</returns>
        public Mailer IsBodyHtml(bool isBodyHtml = true)
        {
            this.message.IsBodyHtml = isBodyHtml;
            return this;
        }

        /// <summary>
        /// Sets the message body
        /// </summary>
        /// <param name="body">Message body</param>
        /// <returns>Mailer</returns>
        public Mailer Body(string body)
        {
            this.message.Body = body;
            return this;
        }

        /// <summary>
        /// Sets priority of the message to High
        /// </summary>
        /// <returns></returns>
        public Mailer HighPriority()
        {
            this.message.Priority = MailPriority.High;
            return this;
        }
        /// <summary>
        /// Sets priority of the message to Low
        /// </summary>
        /// <returns></returns>
        public Mailer LowPriority()
        {
            this.message.Priority = MailPriority.Low;
            return this;
        }

        /// <summary>
        /// Adds an attachment to the message
        /// </summary>
        /// <returns></returns>
        public Mailer Attachment(Attachment item)
        {
            this.message.Attachments.Add(item);
            return this;
        }

        /// <summary>
        /// Gets the MailMessage object from the wrapper. (Optional)
        /// See the .Send() method to send a message.
        /// </summary>
        /// <returns>MailMessage</returns>
        public MailMessage GetMailMessage()
        {
            return this.message;
        }

        /// <summary>
        /// Send the message using the default SMTP configuration
        /// </summary>
        public void Send()
        {
            using (SmtpClient mailClient = new SmtpClient())
            {
                mailClient.Send(this.GetMailMessage());
            }
        }
    }
}
