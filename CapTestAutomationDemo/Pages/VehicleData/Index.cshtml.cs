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
    public class IndexModel : PageModel
    {
        private readonly CapTestAutomationDemo.Models.CapTestAutomationDemoContext _context;

        public IndexModel(CapTestAutomationDemo.Models.CapTestAutomationDemoContext context)
        {
            _context = context;
        }

        public IList<VehiclesModel> VehiclesModel { get;set; }

        public async Task OnGetAsync()
        {
            VehiclesModel = await _context.VehiclesModel.ToListAsync();
        }
    }
}
