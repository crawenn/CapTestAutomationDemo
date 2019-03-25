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
    public class IndexModel : PageModel
    {
        private readonly CapTestAutomationDemo.Models.CapTestAutomationDemoContext _context;

        public IndexModel(CapTestAutomationDemo.Models.CapTestAutomationDemoContext context)
        {
            _context = context;
        }

        public IList<VehiclesModel> VehiclesModel { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }        
        public SelectList CarMake { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Make { get; set; }
      
        public async Task OnGetAsync()
        {
            var cars = from m in _context.VehiclesModel
                       select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                cars = cars.Where(s => s.Make.Contains(SearchString));
            }

            VehiclesModel = await _context.VehiclesModel.ToListAsync();
        }
    }
}
