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
    
### Install
	PM> Install-Package Missive

### See how Razor templates work
[https://github.com/EdCharbeneau/Missive/tree/master/Missive.Templates.Razor](https://github.com/EdCharbeneau/Missive/tree/master/Missive.Templates.Razor "Razor Templates")

	PM> Install-Package Missive.Templates.Razor