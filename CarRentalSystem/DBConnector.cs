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
                    resultList.Close();
                    query.Dispose();
                    cnn.Close();
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

            return output;
        }

        public int getLevel(string username)
        {
            int output = -1;
            cnn.Open();
            SqlCommand query = new SqlCommand("SELECT USERLEVEL.TYPE from USERLEVEL INNER JOIN USERS ON USERS.USERLEVEL = USERLEVEL.LID and USERS.USERNAME = '"+ username +"'; ", cnn);
            SqlDataReader resultList = null;
            try
            {
                resultList = query.ExecuteReader();
                if (resultList.Read())
                {
                    output = Convert.ToInt32(resultList.GetValue(0));
                    resultList.Close();
                    query.Dispose();
                    cnn.Close();
                }
                else
                {
                    resultList.Close();
                    query.Dispose();
                    cnn.Close();
                    output = -1;
                }
            }
            catch
            {
                query.Dispose();
                cnn.Close();
                output = -1;
            }

            return output;
        }

        public List<Car> getAllCars()
        {
            return null;
        }

        public List<Car> getAllAvailableCars()
        {
            return null;
        }
        public void saveSession(Session session)
        {
           
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

        private int generateID(string table)
        {
            int output = -1;
            cnn.Open();
            SqlCommand query = new SqlCommand("SELECT MAX(SESSION_ID) FROM " + table + ";", cnn);
            SqlDataReader resultList = null;
            try
            {
                resultList = query.ExecuteReader();
                if (resultList.Read())
                {
                    output = (Convert.ToInt32(resultList.GetValue(0))+1);
                    resultList.Close();
                    query.Dispose();
                    cnn.Close();
                }
                else
                {
                    resultList.Close();
                    query.Dispose();
                    cnn.Close();
                    output = -1;
                }
            }
            catch
            {
                query.Dispose();
                cnn.Close();
                output = -1;
            }
            return output;
        }

        private string toSqlDateTime(DateTime dateTime)
        {
            return dateTime.ToString("yyyyMMdd hh:mm:ss tt");
        }
    }
}
