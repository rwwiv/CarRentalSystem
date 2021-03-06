﻿using System;
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
                if (resultList.Count <= 0)
                    return null;
                else
                return resultList.First();
            }

        }

        public int getLevel(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<int>("select User.user_level from User where User.username = '" + username + "';", new DynamicParameters());
                var resultList = output.ToList<int>();
                if (resultList.Count <= 0)
                    return -1;
                else
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

        public bool saveSession(Session session)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                int rowsEffected = cnn.Execute("insert into Session (username,login) values(@username, @login)",session);
                if (rowsEffected <= 0)
                    return false;
                else
                    return true;

            }    
        }

        public bool logoutSession(Session session)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                int rowsEffected = cnn.Execute("insert into Session (username,login,logout) values(@username, @login, @logout)", session);

                if (rowsEffected <= 0)
                    return false;
                else
                    return true;
            }
        }

        public bool getAvailability(Car car)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<int>("select Car.is_available from Car where Car.vin = '" + car.vin + "';", new DynamicParameters());
                var resultList = output.ToList<int>();
                if (resultList.Count <= 0)
                    return false;
                else
                    return Convert.ToBoolean(resultList.First());
            }
        }

        public bool saveAvailability(Car car)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                int rowsEffected;
                if (car.description == null || car.description == "")
                {
                    rowsEffected = cnn.Execute("Update Car Set is_available = " + Convert.ToInt32(car.is_available) + ", description = " + "'" + "Car returned from user and is ready for new rental client." + "'" + "where vin = '" + car.vin + "'", car);
                }
                else
                {
                    rowsEffected = cnn.Execute("Update Car Set is_available = " + Convert.ToInt32(car.is_available) + ", description = " + "'" + car.description + "'" + "where vin = '" + car.vin + "'", car);
                }
                if (rowsEffected <= 0)
                    return false;
                else
                    return true;
            }
        }

        public int saveRental(Rental rental, string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                Car queryCar = new Car();
                queryCar.vin = rental.car;
                if (!getAvailability(queryCar))
                {
                    return 0;
                }
                int rowsEffected = cnn.Execute("insert into Rental (car_vin, cost, time_start, time_end, user_id) values(@car, @cost, @timeStart, @timeEnd, '"+ username +"')", rental);
                Car tempCar = new Car();
                tempCar.is_available = false;
                tempCar.vin = rental.car;
                tempCar.description = "Car rented out to " + username;
                saveAvailability(tempCar);
                if (rowsEffected <= 0)
                    return -1;
                else
                    return rowsEffected;
            }
        }

        public List<Session> getAllSessions()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<Session>("select * from Session;", new DynamicParameters());
                return output.ToList();
            }
        }

        public List<Rental> getAllRentals()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<Rental>("select * from Session;", new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
