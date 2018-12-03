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
        public string car { get; set; }
        public int cost { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }

        public Rental(string vin, int cost, DateTime timeStart, DateTime timeEnd) {
            this.car = vin;
            this.cost = cost;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
        }
    }
}
