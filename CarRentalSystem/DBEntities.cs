using CarRentalSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public partial class DBEntities : DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<User> User { get; set; }
    }
}
