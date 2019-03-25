using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CapTestAutomationDemo.Models
{
    public class CapTestAutomationDemoContext : DbContext
    {
        public CapTestAutomationDemoContext (DbContextOptions<CapTestAutomationDemoContext> options)
            : base(options)
        {
        }

        public DbSet<CapTestAutomationDemo.Models.VehiclesModel> VehiclesModel { get; set; }
    }
}
