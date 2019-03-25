using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CapTestAutomationDemo.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            string directory = Environment.CurrentDirectory;
            Message = String.Format("Your directory is {0}.", directory);
            //Message = "Web application to showcase test automation capabilities.";
        }
    }
}
