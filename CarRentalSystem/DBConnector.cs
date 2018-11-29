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
            string output = "";
            cnn.Open();
            SqlCommand query = new SqlCommand("SELECT PASSWORD FROM USERS WHERE USERNAME = '" + username + "'" ,cnn);
            SqlDataReader resultList = null;
            try
            {
                resultList = query.ExecuteReader();
                if (resultList.Read())
                {
                    output = resultList.GetValue(0).ToString();
                }
                else
                {
                    resultList.Close();
                    query.Dispose();
                    cnn.Close();
                    output = "userNotFound";
                }
            }
            catch
            {
                query.Dispose();
                cnn.Close();
                output = "badQuery";
            }
            finally
            {
                resultList.Close();
                query.Dispose();
                cnn.Close();
            }

            return output;
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
