using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Controllers
{
    class RentController
    {
        public static void rent(Car car,string username)
        {
            CarRentalSystem.Views.RentConfirm rentConfirm = new CarRentalSystem.Views.RentConfirm(car, username);
            rentConfirm.Show();
        }

        public static bool confirm(Rental currentRental, string username) {
            DBConnector currentConnection = new DBConnector();
            return currentConnection.saveRental(currentRental, username);
        }
    }
}
