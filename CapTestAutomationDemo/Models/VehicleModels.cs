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

        [DataType(DataType.Date)]        
        public DateTime Year { get; set; }
        public string Make { get; set; }
        [Display(Name = "Model")]
        public string CarModel { get; set; }
        [Display(Name = "Body style")]
        public string BodyStyle { get; set; }
        [Display(Name = "Fuel type")]
        public string FuelType { get; set; }
        [Display(Name = "Engine Size")]
        public double EngineSize { get; set; }
        [Display(Name = "Insurance package")]
        public int InsurancePackage { get; set; }
    }
}