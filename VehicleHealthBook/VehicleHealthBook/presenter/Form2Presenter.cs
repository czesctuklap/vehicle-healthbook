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
    public class Form2Presenter
    {
        private Form2 _view;
        private VehiclesList _model;
        private Form1 _form1;
        private VehicleRepository _vehicleRepository;

        public Form2Presenter(Form2 view, VehiclesList model, Form1 form1)
        {
            _view = view;
            _model = model;
            _form1 = form1;
            _vehicleRepository = new VehicleRepository("Server=localhost;Database=vehicle_healthbook;User Id=root;Password=kamil;");
            _view.AddVehicle += AddVehicle;
            _view.goToVehicleList += _view_goToVehicleList;
        }

        private void AddVehicle()
        {
            if (String.IsNullOrEmpty(_view.getProducer()) ||
                String.IsNullOrEmpty(_view.getModel()) ||
                String.IsNullOrEmpty(_view.getYear_produced()) ||
                String.IsNullOrEmpty(_view.getLicense_number()) ||
                String.IsNullOrEmpty(_view.getMileage()) ||
                String.IsNullOrEmpty(_view.getModel()))
            {
                MessageBox.Show("Pola nie mogą być puste!");
            }
            else
            {
                Vehicle veh = new Vehicle(
                    _view.getProducer(),
                    _view.getModel(),
                    _view.getYear_produced(),
                    _view.getLicense_number(),
                    _view.getMileage(),
                    _view.getInsurance_Date,
                    _view.getMot_Date,
                    _view.getType()
                );
                _vehicleRepository.AddVehicle(veh);
                MessageBox.Show("działa");
                _view.ClearForm();
                _form1.Presenter.LoadVehicles(); // Load the updated list of vehicles
                _view_goToVehicleList(this, EventArgs.Empty);
            }
        }

        private void _view_goToVehicleList(object sender, EventArgs e)
        {
            _view.Hide();
            _form1.Show();
        }
    }

}
