using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHealthBook.Model
{
    public enum VehicleType
    {
        Car,
        Truck,
        Motorcycle,
        Bus,
        Van,
        SUV
    }

    public class Vehicle
    {
        //public int Id { get; set; }
        public string Producer {  get; set; }
        public string Model {  get; set; }
        public string Year_produced { get; set; }
        public string License_plate_number { get; set; }
        public string Mileage {  get; set; }
        public DateTime Insurance_date { get; set; }
        public DateTime MOT_date { get; set; }
        public VehicleType Type { get; set; }

        public Vehicle(/*int id, */string producer, string model, string year_produced, string license_plate_number, string mileage, DateTime insurance_date, DateTime mot_date, VehicleType type)
        {
            //Id = id;
            Producer = producer;
            Model = model;
            Year_produced = year_produced;
            License_plate_number = license_plate_number;
            Mileage = mileage;
            Insurance_date = insurance_date;
            MOT_date = mot_date;
            Type = type;
        }

        public Vehicle() { }
    }
}
