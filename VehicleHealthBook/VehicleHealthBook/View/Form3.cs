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

        private void deleteVehicle(object sender, EventArgs e)
        {
            _form1.deleteVehicle(sender, e);
            GoToVehicleList?.Invoke(this, EventArgs.Empty);
        }

        private void goToVehicleList(object sender, EventArgs e)
        {
            GoToVehicleList?.Invoke(this, EventArgs.Empty);
        }
    }
}
