#Missive

Missive is a simple Fluent API wrapper for the .NET System.Net.MailMessage object.

Because sometimes things just need to be "that" easy.

##Usage

*Send a mail message*

//Uses application mail settings
Mailer.Create()
    .From("from@domain.com")
    .To("email@domain.com")
    .Subject("Missive")
    .Body("Hello World")
    .Send();

