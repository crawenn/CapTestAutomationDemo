using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
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

        public IList<VehiclesModel> VehiclesModel { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Year { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CarYear { get; set; }
      
        public async Task OnGetAsync()
        {
            var culture = new CultureInfo("en-GB");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            IQueryable<string> ageQuery = from m in _context.VehiclesModel
                                          orderby m.Year.ToString()
                                          select m.Year.ToString();

            var cars = from m in _context.VehiclesModel
                       select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                cars = cars.Where(s => s.Make.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CarYear))
            {
                cars = cars.Where(x => x.Year.ToString() == CarYear);
            }

            Year = new SelectList(await ageQuery.Distinct().ToListAsync());
            VehiclesModel = await cars.ToListAsync();
            //VehiclesModel = await _context.VehiclesModel.ToListAsync();            
        }
    }
}
