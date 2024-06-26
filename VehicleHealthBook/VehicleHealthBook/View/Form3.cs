using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleHealthBook.Model;
using VehicleHealthBook.View;
using VehicleHealthBook.Presenter;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;

namespace VehicleHealthBook.View
{
    public partial class Form3 : Form
    {
        private Form3Presenter presenter;
        private VehiclesList _vehicleList;
        private Form1 _form1;
        public VehiclesList vehicleList
        {
            get => _vehicleList;
            set => _vehicleList = value;
        }

        public Form3(
            VehiclesList vList,
            Form1 form1, string producer,
            string model, string yearProduced,
            string licensePlate, string mileage,
            DateTime insuranceDate,
            DateTime motDate,
            string type)
        {
            InitializeComponent();
            _vehicleList = vList;  // Ustawienie istniejącej listy pojazdów
            presenter = new Form3Presenter(this, _vehicleList, form1);  // Przekazanie referencji do Form1 do presenter
            _form1 = form1;
            this.FormClosing += Form3_FormClosing;

            // Możesz też dodać event handlers lub inicjalizację UI
            label9.Text = type;
            label10.Text = producer;
            label11.Text = model;
            label12.Text = yearProduced;
            label13.Text = mileage;
            label14.Text = insuranceDate.ToString("dd-MM-yyyy");
            label15.Text = motDate.ToString("dd-MM-yyyy");
            label16.Text = licensePlate;
        }


        public event EventHandler GoToVehicleList;

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void deleteVehicle(object sender, EventArgs e)
        {
            _form1.deleteVehicle(sender, e);
            GoToVehicleList?.Invoke(this, EventArgs.Empty);
        }

        private void goToVehicleList(object sender, EventArgs e)
        {
            GoToVehicleList?.Invoke(this, EventArgs.Empty);
        }

        private void editVehicleButton_Click(object sender, EventArgs e)
        {
            var selectedVehicle = new Vehicle(
                label10.Text, // Producer
                label11.Text, // Model
                label12.Text, // YearProduced
                label16.Text, // LicenseNumber
                label13.Text, // Mileage
                DateTime.Parse(label14.Text), // InsuranceDate
                DateTime.Parse(label15.Text), // MotDate
                (VehicleType)Enum.Parse(typeof(VehicleType), label9.Text) // Type
            );

            Form4 form4 = new Form4(_vehicleList, _form1, selectedVehicle);
            form4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
