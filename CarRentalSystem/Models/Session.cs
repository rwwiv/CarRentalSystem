using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Session
    {
        [Key]
        public int sessionId { get; set; }
        public string username { get; set; }
        public DateTime login { get; set; }
        public DateTime logout { get; set; }
    }
}
