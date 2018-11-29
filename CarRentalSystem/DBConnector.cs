using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CarRentalSystem
{
    class DBConnector
    {
        SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB.mdf;Integrated Security = True");
        public string getUserCred(string username)
        {
            cnn.Open();
            SqlCommand query = new SqlCommand("SELECT PASSWORD FROM USER WHERE USERNAME = " + username ,cnn);
            SqlDataReader resultList = query.ExecuteReader();
            return resultList.GetValue(0).ToString();
        }

        public int getLevel(string username)
        {
            //TODO
            return -1;
        }

        public void saveSession(Session session)
        {
            //TODO
        }

        public void logoutSession(Session session)
        {
            //TODO
        }

        public bool getAvailability(Car car)
        {
            //TODO
            return false;
        }

        public void saveAvailability(Car car)
        {
            //TODO
        }

        public void saveRental(Rental rental)
        {
            //TODO
        }

    }
}
