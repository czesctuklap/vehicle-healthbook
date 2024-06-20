/*using VehicleHealthBook.Model;
using VehicleHealthBook.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using VehicleHealthBook;

namespace VehicleHealthBook.Presenter
{
    class MainPresenter
    {
        private Form1 _view;
        private Model.VehiclesList _model;
        private ColumnHeader _lastClickedHeader;
        private System.Windows.Forms.SortOrder _sortOrder = System.Windows.Forms.SortOrder.Ascending;

        public MainPresenter(Form1 view, Model.VehiclesList model)
        {
            _view = view;
            _model = model;
            _view.AddVehicle += _view_AddVehicle;
            _view.SelectVehicle += _view_SelectVehicle;
            _view.DeleteVehicle += _view_DeleteVehicle;
            _view.ColumnHeaderClicked += _view_ColumnHeaderClicked;
        }

        private Form1 _form;

        public MainPresenter(Form1 form)
        {
            _form = form;
        }

        private void _view_AddVehicle()
        {
            if (String.IsNullOrEmpty(_view.getProducer()) || String.IsNullOrEmpty(_view.getModel()) || String.IsNullOrEmpty(_view.getYear_produced()) || String.IsNullOrEmpty(_view.getLicense_plate_number()) || String.IsNullOrEmpty(_view.getMilage()) || String.IsNullOrEmpty(_view.getModel()))
            {
                MessageBox.Show("Pola nie mogą być puste!");
            }
            else
            {
                Vehicle veh = new Vehicle(_view.getProducer(), _view.getModel(), _view.getYear_produced(), _view.getLicense_plate_number(), _view.getMilage(), _view.getInsurace_date(), _view.getMOT_date(), _view.getType());
                _view.vehicleslist.list.Add(veh);
                _view.addToListView();
            }
        }
        private void _view_SelectVehicle(int index)
        {
            if (index >= 0 && index < _form.lvEvents.Items.Count)
            {
                var selectedItem = _form.lvEvents.Items[index];
                string title = selectedItem.SubItems[0].Text;
                string description = selectedItem.SubItems[1].Text;
                DateTime date = DateTime.Parse(selectedItem.SubItems[2].Text);
                string type = selectedItem.SubItems[3].Text;
                string priority = selectedItem.SubItems[4].Text;

                _view.setFormValues(title, description, date, type, priority);
            }
        }


        private void _view_DeleteVehicle(int index)
        {
            if (index >= 0 && index < _view.lvEvents.Items.Count)
            {
                _view.lvEvents.Items.RemoveAt(index);
            }
        }

        private void _view_ColumnHeaderClicked(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader clickedHeader = _view.lvEvents.Columns[e.Column];

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
}*/