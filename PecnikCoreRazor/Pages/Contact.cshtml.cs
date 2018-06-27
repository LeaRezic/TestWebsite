using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.AspNetCore.Mvc.Localization;
using PecnikCoreRazor.Models;

namespace PecnikCoreRazor.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactFormModel Contact { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
            
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                //return RedirectToPage("Contact");
                return Content("Ne valja ti model!");
            }
            Execute(Contact).Wait();
            //return RedirectToPage("Contact");
            return Content("Poslan mail, bravo!");
        }

        static async Task Execute(ContactFormModel Contact)
        {
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress($"{Contact.Email}", $"{Contact.Name} {Contact.LastName}");
            var subject = "Email from my website - TestniPećnikWeb";
            var to = new EmailAddress("lrezic@racunarstvo.hr", "Ja");
            var plainTextContent = $"{Contact.Message}";
            var htmlContent = $"<strong>{Contact.Message}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }

    public class ContactFormModel
    {
        [Required(ErrorMessage = "Name is a required field.")]
        public string Name { get; set; }

        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Email must be in correct format.")]
        [Required(ErrorMessage = "Email is a required field.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message is a required field.")]
        public string Message { get; set; }

        //[Required(ErrorMessage = "Name is a required field.")]
        //public string Name { get; set; }

        //public string LastName { get; set; }

        //[Required]
        //public string Email { get; set; }

        //[Required]
        //public string Message { get; set; }
    }

}
