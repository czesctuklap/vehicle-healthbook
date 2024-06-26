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
    class Form3Presenter
    {
        private Form3 _view;
        private VehiclesList _model;
        private Form1 _form1;
        public Form3Presenter(Form3 view, VehiclesList model, Form1 form1)
        {
            _view = view;
            _model = model;
            _form1 = form1; // Zapisanie referencji do Form1
            _view.GoToVehicleList += _view_GoToVehicleList;
        }

        private void _view_GoToVehicleList(object sender, EventArgs e)
        {
            _view.Hide();
            _form1.Show();
        }
    }
}
