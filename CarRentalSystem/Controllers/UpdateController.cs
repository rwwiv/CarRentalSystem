using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class UpdateController
    {

        public static void update(Car car)
        {
            CarRentalSystem.Views.UpdateConfirm updateConfirm = new CarRentalSystem.Views.UpdateConfirm(car);
            updateConfirm.Show();
        }

        public static bool confirm(Car car) {
            DBConnector currentConnection = new DBConnector();
            return currentConnection.saveAvailability(car);
        }
    }
}
