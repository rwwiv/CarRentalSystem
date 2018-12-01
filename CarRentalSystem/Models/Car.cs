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
        public string vin { get; private set; }
        public string color { get; private set; }
        public string model { get; private set; }
        public string make { get; private set; }
        public bool isAvailable { get; private set; }
        public int costPerDay { get; private set; }
    }
}
