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
            MessageBox.Show("1");
            using (var connection = new MySqlConnection(connectionString))
            {
                MessageBox.Show("2");
                connection.Open();
                var query = "INSERT INTO vehicles VALUES (@producer, @model, @production_year, @license_plate_num, @mileage, @insurance_date, @mot_date, @type)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Producer", vehicle.Producer);
                    command.Parameters.AddWithValue("@Model", vehicle.Model);
                    command.Parameters.AddWithValue("@YearProduced", vehicle.Year_produced);
                    command.Parameters.AddWithValue("@LicenseNumber", vehicle.Year_produced);
                    command.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
                    command.Parameters.AddWithValue("@InsuranceDate", vehicle.Insurance_date);
                    command.Parameters.AddWithValue("@MotDate", vehicle.Mot_date);
                    command.Parameters.AddWithValue("@Type", vehicle.Type.ToString());

                    command.ExecuteNonQuery();
                }
            }
        }
    }

}
