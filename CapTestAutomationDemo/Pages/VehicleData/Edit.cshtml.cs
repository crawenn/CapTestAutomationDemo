using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CapTestAutomationDemo.Models;

namespace CapTestAutomationDemo.Pages.VehicleData
{
    public class EditModel : PageModel
    {
        private readonly CapTestAutomationDemo.Models.CapTestAutomationDemoContext _context;

        public EditModel(CapTestAutomationDemo.Models.CapTestAutomationDemoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VehiclesModel VehiclesModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VehiclesModel = await _context.VehiclesModel.FirstOrDefaultAsync(m => m.ID == id);

            if (VehiclesModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VehiclesModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiclesModelExists(VehiclesModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VehiclesModelExists(int id)
        {
            return _context.VehiclesModel.Any(e => e.ID == id);
        }
    }
}
