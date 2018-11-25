using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Car
    {
        private string vin { get; set; }
        private string color { get; set; }
        private string model { get; set; }
        private string make { get; set; }
        private Boolean isAvailable { get; set; }
        private int costPerDay { get; set; }
    }
}
