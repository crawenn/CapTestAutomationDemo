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
        public string CarModel { get; set; }
        public string BodyStyle { get; set; }
        public string InsurancePackage { get; set; }
    }
}
