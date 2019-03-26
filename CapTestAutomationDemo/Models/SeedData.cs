using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CapTestAutomationDemo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CapTestAutomationDemoContext(
                serviceProvider.GetRequiredService<DbContextOptions<CapTestAutomationDemoContext>>()))
            {
                if (context.VehiclesModel.Any())
                {
                    return;
                }

                context.VehiclesModel.AddRange(
                    new VehiclesModel
                    {
                        Year = DateTime.Parse("2017-01-01"),
                        Make = "Honda",
                        CarModel = "Jazz",
                        BodyStyle = "Hatchback",
                        FuelType = "petrol",
                        EngineSize = 1.5d,
                        InsurancePackage = 3
                    },

                    new VehiclesModel
                    {
                        Year = DateTime.Parse("2014-01-01"),
                        Make = "Audi",
                        CarModel = "A6",
                        BodyStyle = "Sedan",
                        FuelType = "diesel",
                        EngineSize = 2.0d,
                        InsurancePackage = 3
                    },

                    new VehiclesModel
                    {
                        Year = DateTime.Parse("2007-01-01"),
                        Make = "Suzuki",
                        CarModel = "SX4",
                        BodyStyle = "Hatchback",
                        FuelType = "diesel",
                        EngineSize = 1.6d,
                        InsurancePackage = 2
                    });
                context.SaveChanges();
            }
        }
    }
}
