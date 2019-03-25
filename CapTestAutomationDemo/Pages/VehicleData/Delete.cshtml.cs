using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapTestAutomationDemo.Models;

namespace CapTestAutomationDemo.Pages.VehicleData
{
    public class DeleteModel : PageModel
    {
        private readonly CapTestAutomationDemo.Models.CapTestAutomationDemoContext _context;

        public DeleteModel(CapTestAutomationDemo.Models.CapTestAutomationDemoContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VehiclesModel = await _context.VehiclesModel.FindAsync(id);

            if (VehiclesModel != null)
            {
                _context.VehiclesModel.Remove(VehiclesModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
