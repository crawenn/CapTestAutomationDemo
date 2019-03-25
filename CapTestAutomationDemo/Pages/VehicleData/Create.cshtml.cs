using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CapTestAutomationDemo.Models;

namespace CapTestAutomationDemo.Pages.VehicleData
{
    public class CreateModel : PageModel
    {
        private readonly CapTestAutomationDemo.Models.CapTestAutomationDemoContext _context;

        public CreateModel(CapTestAutomationDemo.Models.CapTestAutomationDemoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VehiclesModel VehiclesModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VehiclesModel.Add(VehiclesModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}