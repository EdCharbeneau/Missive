# A Razor template helper for email

Just call .ToEmailBody and supply the template and Razor will do the rest; it's that easy.

## Usage
    // Apply the razor template to your model
    var model = new Person() { FirstName = "Walter", LastName = "White" };
    var template = "Hello, my name is @Model.FirstName, @Model.LastName";
    var emailBody = model.ToEmailBody(template); 
    // "Hello, my name is Walter, White";

### More
    // Grab your template from an external file
    var path = HttpContext.Current.Server.MapPath("ThankYou.cshtml"); // From a server path, no problem.
    string template = System.IO.File.ReadAllText(path);

    ThankYou.cshtml
    <p>Dear @Model.FirstName, @Model.LastName:</p>
    <p>Thanks for keeping it simple.</p>

## Use it with Missive Fluent API

You don't have to, but you can. Because it's just that easy, and they go together like peas and carrots anyway.

    //Uses application mail settings
    Mailer.Create()
    .From("from@domain.com")
    .To("email@domain.com")
    .Subject("Hello World")
    .Body(model.ToEmailBody(template))
    .Send();

### Install
    PM> Install-Package Missive (optional)
    PM> Install-Package Missive.Templates.Razor