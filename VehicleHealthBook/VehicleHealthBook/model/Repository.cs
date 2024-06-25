using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VehicleHealthBook.Model
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Windows.Forms;

    public class VehicleRepository
    {
        private string connectionString;

        public VehicleRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO vehicles (producer, model, production_year, license_plate_num, mileage, insurance_date, mot_date, type) " +
                            "VALUES (@producer, @model, @production_year, @license_plate_num, @mileage, @insurance_date, @mot_date, @type)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@producer", vehicle.Producer);
                    command.Parameters.AddWithValue("@model", vehicle.Model);
                    command.Parameters.AddWithValue("@production_year", vehicle.Year_produced);
                    command.Parameters.AddWithValue("@license_plate_num", vehicle.License_number); // Poprawione z Year_produced na License_number
                    command.Parameters.AddWithValue("@mileage", vehicle.Mileage);
                    command.Parameters.AddWithValue("@insurance_date", vehicle.Insurance_date);
                    command.Parameters.AddWithValue("@mot_date", vehicle.Mot_date);
                    command.Parameters.AddWithValue("@type", vehicle.Type.ToString());

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Vehicle> GetAllVehicles()
        {
            var vehicles = new List<Vehicle>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT producer, model, production_year, license_plate_num, mileage, insurance_date, mot_date, type FROM vehicles";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var vehicle = new Vehicle
                            {
                                Producer = reader.GetString("producer"),
                                Model = reader.GetString("model"),
                                Year_produced = reader.GetString("production_year"),
                                License_number = reader.GetString("license_plate_num"),
                                Mileage = reader.GetString("mileage"),
                                Insurance_date = reader.GetDateTime("insurance_date"),
                                Mot_date = reader.GetDateTime("mot_date"),
                                Type = (VehicleType)Enum.Parse(typeof(VehicleType), reader.GetString("type"))
                            };

                            vehicles.Add(vehicle);
                        }
                    }
                }
            }

            return vehicles;
        }

    }

}
