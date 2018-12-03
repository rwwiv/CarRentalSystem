using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class LoginController
    {
        public static bool verifyUser(string username, string password, LoginForm login)
        {
            DBConnector currentConnection = new DBConnector();
            string currentPW = currentConnection.getUserCred(username);
            if (!String.IsNullOrEmpty(currentPW))
            {
                if (validate(password, currentPW))
                {
                    User currentUser = new User(username, password, currentConnection.getLevel(username));

                    Session currentSession = new Session(username);                
                    currentSession.login = DateTime.Now;
                    currentConnection.saveSession(currentSession);

                    List<Car> currentCars = new List<Car>();

                    if (currentUser.userLevel == 1)
                    {
                        currentCars = currentConnection.getAllCars();
                        CarRentalSystem.Views.AdminMenuForm adminMenu = new CarRentalSystem.Views.AdminMenuForm(currentSession, currentUser, currentCars);
                        adminMenu.login = login;
                        adminMenu.Show();
                    }
                    else
                    {
                        currentCars = currentConnection.getAllAvailableCars();
                        CarRentalSystem.Views.UserMenuForm userMenu = new CarRentalSystem.Views.UserMenuForm(currentSession, currentUser, currentCars);
                        userMenu.login = login;
                        userMenu.Show();
                    }
                    return true;
                }
            }
            return false;
        }

        public static bool validate(string input, string dbpw)
        {
            HashAlgorithm algo = MD5.Create();
            byte[] temp = algo.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in temp) {
                sb.Append(b.ToString("X2"));
            }
            string hashedPW = sb.ToString();

            if (hashedPW.Equals(dbpw))
            {
                return true;
            }
            return false;
        }
    }
}
