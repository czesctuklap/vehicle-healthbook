using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleHealthBook.Model;
using VehicleHealthBook.View;

namespace VehicleHealthBook.Presenter
{
    internal class Form4Presenter
    {
        private Form4 _view;
        private VehiclesList _model;
        private Form1 _form1;
        private VehicleRepository _vehicleRepository;
        private Vehicle _currentVehicle;

        public Form4Presenter(Form4 view, VehiclesList model, Form1 form1, Vehicle vehicle)
        {
            _view = view;
            _model = model;
            _form1 = form1;
            _currentVehicle = vehicle;
            _vehicleRepository = new VehicleRepository("Server=localhost;Database=vehicle_healthbook;User Id=root;Password=kamil;");

            _view.GoToVehicleList += _view_GoToVehicleList;
            _view.UpdateVehicle += UpdateVehicle;

            LoadVehicleData();
        }

        private void LoadVehicleData()
        {
            _view.SetProducer(_currentVehicle.Producer);
            _view.SetModel(_currentVehicle.Model);
            _view.SetYearProduced(_currentVehicle.Year_produced);
            _view.SetLicenseNumber(_currentVehicle.License_number);
            _view.SetMileage(_currentVehicle.Mileage);
            _view.SetInsuranceDate(_currentVehicle.Insurance_date);
            _view.SetMotDate(_currentVehicle.Mot_date);
            _view.SetType(_currentVehicle.Type);
        }

        private void UpdateVehicle(object sender, EventArgs e)
        {
            string oldLicensePlateNumber = _currentVehicle.License_number; // Store the old license plate number
            _currentVehicle.Producer = _view.GetProducer();
            _currentVehicle.Model = _view.GetModel();
            _currentVehicle.Year_produced = _view.GetYearProduced();
            _currentVehicle.License_number = _view.GetLicenseNumber();
            _currentVehicle.Mileage = _view.GetMileage();
            _currentVehicle.Insurance_date = _view.GetInsuranceDate();
            _currentVehicle.Mot_date = _view.GetMotDate();
            _currentVehicle.Type = _view.GetType();

            _vehicleRepository.UpdateVehicle(_currentVehicle, oldLicensePlateNumber); // Pass old license plate number
            _form1.Presenter.LoadVehicles(); // Reload the updated list of vehicles
            _view_GoToVehicleList(this, EventArgs.Empty);
            MessageBox.Show("Vehicle updated successfully.");
        }

        private void _view_GoToVehicleList(object sender, EventArgs e)
        {
            _view.Hide();
            _form1.Show();
        }
    }
}
