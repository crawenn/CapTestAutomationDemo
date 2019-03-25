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
                        Year = DateTime.Parse("2017"),
                        Make = "Honda",
                        CarModel = "Jazz",
                        BodyStyle = "Hatchback",
                        FuelType = "petrol",
                        EngineSize = 1.5f,
                        InsurancePackage = 3
                    },

                    new VehiclesModel
                    {
                        Year = DateTime.Parse("2014"),
                        Make = "Audi",
                        CarModel = "A6",
                        BodyStyle = "Sedan",
                        FuelType = "diesel",
                        EngineSize = 2.0f,
                        InsurancePackage = 3
                    },

                    new VehiclesModel
                    {
                        Year = DateTime.Parse("2007"),
                        Make = "Suzuki",
                        CarModel = "SX4",
                        BodyStyle = "Hatchback",
                        FuelType = "diesel",
                        EngineSize = 1.6f,
                        InsurancePackage = 2
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
