using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Rental
    {
        private Car car { get; set; }
        private double cost { get; set; }
        private DateTime timeStart { get; set; }
        private DateTime timeEnd { get; set; }
    }
}
