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
        public string username { get; private set; }
        public string password { get; private set; }
        public int userLevel { get; private set;  }
    }
}
