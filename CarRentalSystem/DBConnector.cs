using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace CarRentalSystem
{
    class DBConnector
    {
        public string getUserCred(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<string>("select User.password from User where User.username = '" + username + "';", new DynamicParameters());
                var resultList = output.ToList<string>();
                return resultList.First();
            }

        }

        public int getLevel(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<int>("select User.user_level from User where User.username = '" + username + "';", new DynamicParameters());
                var resultList = output.ToList<int>();
                return resultList.First();
            }
        }

        public List<Car> getAllCars()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<Car>("select * from Car;", new DynamicParameters());
                return output.ToList();
            }
        }

        public List<Car> getAllAvailableCars()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<Car>("select * from Car where is_available = 1;", new DynamicParameters());
                return output.ToList();
            }
        }
        public void saveSession(Session session)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("insert into Session (username,login) values(@username, @login)",session);

                var output = cnn.Query<Object>("select * from Session;", new DynamicParameters());
                var resultList = output.ToList();
                System.Threading.Thread.Sleep(20);
            }    
        }

        public void logoutSession(Session session)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("insert into Session (username,login,logout) values(@username, @login, @logout)", session);
            }
        }

        public bool getAvailability(Car car)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<int>("select Car.is_available from Car where Car.vin = '" + car.vin + "';", new DynamicParameters());
                var resultList = output.ToList<int>();
                return Convert.ToBoolean(resultList.First());
            }
        }

        public void saveAvailability(Car car)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Update Car Set is_available = " + Convert.ToInt32(car.isAvailable) + "where vin = '" + car.vin + "'", car);
            }
        }

        public void saveRental(Rental rental)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("insert into Rental (car_vin, cost, time_start, time_end) values(@car, @cost, @timeStart, @timeEnd)", rental);
            }
        }
    }
}
