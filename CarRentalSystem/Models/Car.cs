using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Car
    {
        [Key]
        private string vin { get; set; }
        private string color { get; set; }
        private string model { get; set; }
        private string make { get; set; }
        private bool isAvailable { get; set; }
        private int costPerDay { get; set; }
    }
}
