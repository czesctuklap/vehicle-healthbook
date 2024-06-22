using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleHealthBook.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using VehicleHealthBook.View;

namespace VehicleHealthBook.Presenter
{
    class Form1Presenter
    {
        private Form1 _view;
        private Model.VehiclesList _model;
        private ColumnHeader _lastClickedHeader;
        private System.Windows.Forms.SortOrder _sortOrder = System.Windows.Forms.SortOrder.Ascending;

        public Form1Presenter(Form1 view, Model.VehiclesList model)
        {
            _view = view;
            _model = model;
            _view.GoToAddVehicle += _view_GoToAddVehicle;
            _view.DeleteVehicle += _view_DeleteVehicle;
            _view.ItemDoubleClick += _view_ItemDoubleClick;
            _view.SelectVehicle += _view_SelectVehicle;
            _view.ColumnHeaderClicked += _view_ColumnHeaderClicked;
        }

        private void _view_GoToAddVehicle(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_model, _view);
            form2.Show();
            _view.Hide();
        }

        private void _view_ItemDoubleClick(object sender, EventArgs e)
        {
            if (_view.listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = _view.listView1.SelectedIndices[0];
                if (selectedIndex >= 0 && selectedIndex < _view.listView1.Items.Count)
                {
                    var selectedItem = _view.listView1.Items[selectedIndex];

                    // Pobierz dane pojazdu z listy
                    string producer = selectedItem.SubItems[0].Text;
                    string model = selectedItem.SubItems[1].Text;
                    string year_produced = selectedItem.SubItems[2].Text;
                    string license_plate_number = selectedItem.SubItems[3].Text;
                    string mileage = selectedItem.SubItems[4].Text;
                    DateTime insurance_date = DateTime.Parse(selectedItem.SubItems[5].Text);
                    DateTime mot_date = DateTime.Parse(selectedItem.SubItems[6].Text);
                    string type = selectedItem.SubItems[7].Text;

                    // Utwórz instancję Form3, przekazując vehicleList i referencję do Form1
                    Form3 form3 = new Form3(_model, _view);
                    form3.vehicleList = _model;  // Przekazanie listy pojazdów do Form3
                    form3.Show();
                    //_view.Hide();
                }
            }
        }


        private void _view_DeleteVehicle(int index)
        {
            if (index >= 0 && index < _view.listView1.Items.Count)
            {
                _view.listView1.Items.RemoveAt(index);
            }
        }

        private Form1 _form;


        private void _view_SelectVehicle(int index)
        {
            if (index >= 0 && index < _form.listView1.Items.Count)
            {
                var selectedItem = _form.listView1.Items[index];
                string producer = selectedItem.SubItems[0].Text;
                string model = selectedItem.SubItems[1].Text;
                string year_produced = selectedItem.SubItems[2].Text;
                string license_plate_number = selectedItem.SubItems[3].Text;
                string mileage = selectedItem.SubItems[4].Text;
                DateTime insurance_date = DateTime.Parse(selectedItem.SubItems[5].Text);
                DateTime mot_date = DateTime.Parse(selectedItem.SubItems[6].Text);
                string type = selectedItem.SubItems[7].Text;
            }
        }

        private void _view_ColumnHeaderClicked(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader clickedHeader = _view.listView1.Columns[e.Column];

            if (clickedHeader == _lastClickedHeader)
            {
                _sortOrder = _sortOrder == System.Windows.Forms.SortOrder.Ascending ? System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                _sortOrder = System.Windows.Forms.SortOrder.Ascending;
                _lastClickedHeader = clickedHeader;
            }

            _view.SortItems(e.Column, _sortOrder);
        }
    }
}
