using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PecnikCoreRazor.Pages
{
    public class LanguageModel : PageModel
    {
        public void OnGet()
        {
            string requestPath = Request.Path;

            if (Request.Cookies[CookieRequestCultureProvider.DefaultCookieName] != null)
            {
                string enCookieValue = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("en"));
                string myCookieValue = Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];
                string newLanguage = (myCookieValue == enCookieValue) ? "hr" : "en";
                Response.Cookies.Delete(CookieRequestCultureProvider.DefaultCookieName);
                AppendLanguageCookie(newLanguage);
            }
            else
            {
                AppendLanguageCookie("hr");
            }
            Response.Redirect("Index");
        }

        public void OnPost()
        {
            //if (Request.Cookies[CookieRequestCultureProvider.DefaultCookieName] != null)
            //{
            //    string enCookieValue = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("en"));
            //    string myCookieValue = Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];
            //    string newLanguage = (myCookieValue == enCookieValue) ? "hr" : "en";
            //    Response.Cookies.Delete(CookieRequestCultureProvider.DefaultCookieName);
            //    AppendLanguageCookie(newLanguage);
            //}
            //else
            //{
            //    AppendLanguageCookie("hr");
            //}
            //Response.Redirect(Request.Path);
        }

        private void AppendLanguageCookie(string newLanguage)
        {
            Response.Cookies.Append
            (
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(newLanguage)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
        }
    }
}