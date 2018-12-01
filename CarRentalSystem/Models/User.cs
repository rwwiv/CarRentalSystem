using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Models
{
    public class User
    {
        [Key]
        private string username { get; set; }
        private string password { get; set; }
        private int userLevel { get; set;  }
    }
}
