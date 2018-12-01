using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Rental
    {
        [Key]
        public int rentalId { get; set; }
        private Car car { get; set; }
        private double cost { get; set; }
        private DateTime timeStart { get; set; }
        private DateTime timeEnd { get; set; }
    }
}
