using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CapTestAutomationDemo.Models
{
    public class VehiclesModel
    {
        public int ID { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true), Required]
        public DateTime Year { get; set; }
        
        [StringLength(20, MinimumLength = 2), Required]
        public string Make { get; set; }

        [Display(Name = "Model"), Required]
        public string CarModel { get; set; }

        [Display(Name = "Body style"), RegularExpression(@"^((S|s)edan|(H|h)atchback|(C|c)oup(e|é)|(L|l)imo?usine|(C|c)abrio)$"), Required]
        public string BodyStyle { get; set; }

        [Display(Name = "Fuel type"), RegularExpression(@"^((P|p)etrol|(D|d)iesel|(H|h)ybrid|(E|e)lectric|LPG|(B|b)iodiesel)$"), Required]
        public string FuelType { get; set; }

        [Display(Name = "Engine Size"), Required]
        public double EngineSize { get; set; }

        [Display(Name = "Insurance package"), Required]
        public int InsurancePackage { get; set; }
    }
}