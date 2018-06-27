using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PecnikCoreRazor.Pages
{
    public class TestModel : PageModel
    {
        //[BindProperty]
        //public ContactFormModel Contact { get; set; }

        public void OnGet()
        {
            
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    Execute(Contact).Wait();
        //    return RedirectToPage("Index");
        //}
        //// tu testiram


        //static async Task Execute(ContactFormModel Contact)
        //{
        //    var apiKey = Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
        //    var client = new SendGridClient(apiKey);
        //    var from = new EmailAddress($"{Contact.Email}", $"{Contact.Name} {Contact.LastName}");
        //    var subject = "Email from my website - TestniPećnikWeb";
        //    var to = new EmailAddress("lrezic@racunarstvo.hr", "Ja");
        //    var plainTextContent = $"{Contact.Message}";
        //    var htmlContent = $"<strong>{Contact.Message}</strong>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var response = await client.SendEmailAsync(msg);
        //}


        //static async Task Execute()
        //    {
        //        var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
        //        var client = new SendGridClient(apiKey);
        //        var msg = new SendGridMessage()
        //        {
        //            From = new EmailAddress("test@example.com", "DX Team"),
        //            Subject = "Hello World from the SendGrid CSharp SDK!",
        //            PlainTextContent = "Hello, Email!",
        //            HtmlContent = "<strong>Hello, Email!</strong>"
        //        };
        //        msg.AddTo(new EmailAddress("test@example.com", "Test User"));
        //        var response = await client.SendEmailAsync(msg);
        //    }




        //var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
        //var client = new SendGridClient(apiKey);
        //var msg = new SendGridMessage()
        //{
        //    From = new EmailAddress(Contact.Email, $"{Contact.Name} {Contact.LastName}"),
        //    Subject = "New message from my website",
        //    PlainTextContent = Contact.Message,
        //    HtmlContent = "<strong>Hello, Email!</strong>"
        //};
        //msg.AddTo(new EmailAddress(Contact.Email));
        //var response = await client.SendEmailAsync(msg);

        // još jednom
        //var apiKey = Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
        //var client = new SendGridClient(apiKey);
        //var from = new EmailAddress("test@example.com", "Example User");
        //var subject = "Sending with SendGrid is Fun";
        //var to = new EmailAddress("test@example.com", "Example User");
        //var plainTextContent = "and easy to do anywhere, even with C#";
        //var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
        //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //var response = await client.SendEmailAsync(msg);



        //Execute().Wait();

        //return Content(Contact.Message);


        //static async Task Execute()
        //{
        //    var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
        //    var client = new SendGridClient(apiKey);
        //    var msg = new SendGridMessage()
        //    {
        //        From = new EmailAddress(Contact.Email),
        //        Subject = "Hello World from the SendGrid CSharp SDK!",
        //        PlainTextContent = "Hello, Email!",
        //        HtmlContent = "<strong>Hello, Email!</strong>"
        //    };
        //    msg.AddTo(new EmailAddress("test@example.com", "Test User"));
        //    var response = await client.SendEmailAsync(msg);
        //}



    }

    // dodajem formu za KONTAKT email
    //public class ContactFormModel
    //{
    //    [Required]
    //    public string Name { get; set; }
    //    [Required]
    //    public string LastName { get; set; }
    //    [Required]
    //    public string Email { get; set; }
    //    [Required]
    //    public string Message { get; set; }
    //}
}