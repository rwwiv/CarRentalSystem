using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class User
    {
        [Key]
        public string username { get; private set; }
        public string password { get; private set; }
        public int userLevel { get; private set;  }

        public User(string username, string password, int userLevel) {
            this.username = username;
            this.password = password;
            this.userLevel = userLevel;
        }
    }
}
