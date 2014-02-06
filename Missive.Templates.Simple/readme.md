# A simple mail template helper

Reads a simple text file, finds and replaces values. Nothing uber, robust, or elite; just simple.

## Usage
	// Finds @@Name in ThankYou.html and replaces it with form values
    var template = new MailTemplate("ThankYou.html"));
    template.Set(new MailTemplateParameters()
    {
    	{"@@FirstName", form.FirstName },
		{"@@LastName", form.LastName },
    });

	ThankYou.html
	<p>Dear @@FirstName @@LastName,</p>
	<p>Thanks for keeping it simple.</p>

### More
	// "@@" works fine, {} works too, it's just a string.
	
	var template = new MailTemplate("ThankYou.html"));
    template.Set(new MailTemplateParameters()
    {
    	{"{FirstName}", form.FirstName },
		{"{LastName}", form.LastName },
    });

	ThankYou.html
	<p>Dear {FirstName} {LastName},</p>
	<p>Thanks for keeping it simple.</p>

## Use it with Missive Fluent API

You don't have to, but you can. Because it's just that easy, and they go together like peas and carrots anyway.

	// Finds @@Name in ThankYou.html and replaces it with form values
    var template = new MailTemplate("ThankYou.html"));
    template.Set(new MailTemplateParameters()
    {
    	{"@@FirstName", form.FirstName },
		{"@@LastName", form.LastName },
    });

    //Uses application mail settings
    Mailer.Create()
    .From("from@domain.com")
    .To("email@domain.com")
    .Subject(template.Body)
    .Body("Hello World")
    .Send();

### Install
	PM> Install-Package Missive (optional)
	PM> Install-Package Missive.Templates.Simple