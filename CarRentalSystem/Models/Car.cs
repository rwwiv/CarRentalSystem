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
        public string vin { get;  set; }
        public string color { get; private set; }
        public string model { get; private set; }
        public string make { get; private set; }
        public string description { get; set; }
        public bool is_available { get; private set; }
        public int cost_per_day { get; private set; }
    }
}
