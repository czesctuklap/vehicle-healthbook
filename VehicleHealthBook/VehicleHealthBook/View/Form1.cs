using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleHealthBook.Model;
using VehicleHealthBook.Presenter;

namespace VehicleHealthBook.View
{
    public partial class Form1 : Form
    {
        public VehiclesList vehicleList;
        public Form1Presenter Presenter;

      public event EventHandler<ColumnClickEventArgs> ColumnHeaderClicked;

        public Form1(VehiclesList vList)
        {
            InitializeComponent();
            vehicleList = vList;
            Presenter = new Form1Presenter(this, vehicleList);
            listView1.ColumnClick += (sender, e) => ColumnHeaderClicked?.Invoke(sender, e);
            listView1.DoubleClick += ItemDoubleClick;
        }

        public void DisplayVehicles(List<Vehicle> vehicles)
        {
            listView1.Items.Clear();
            foreach (var vehicle in vehicles)
            {
                var item = new ListViewItem(new[]
                {
                vehicle.Producer,
                vehicle.Model,
                vehicle.Year_produced,
                vehicle.License_number,
                vehicle.Mileage,
                vehicle.Insurance_date.ToString("dd/MM/yyyy"),
                vehicle.Mot_date.ToString("dd/MM/yyyy"),
                vehicle.Type.ToString()
            });
                listView1.Items.Add(item);
            }
        }

        public event EventHandler GoToAddVehicle;
        public event Action<int> DeleteVehicle;
        public event Action<int> SelectVehicle;
        public event EventHandler ItemDoubleClick;

        public void goToAddVehicle(object sender, EventArgs e)
        {
            GoToAddVehicle?.Invoke(this, EventArgs.Empty);
        }

        public void itemDoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ItemDoubleClick?.Invoke(this, EventArgs.Empty);
                Form3 form3 = new Form3(this.vehicleList, this);  // Przekazanie referencji do Form1
                form3.Show();
                this.Hide();
            }
        }

        public void selectVehicle(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView listView = (System.Windows.Forms.ListView)sender;
            if (listView.SelectedItems.Count == 1)
            {
                int selectedIndex = listView.SelectedIndices[0];
                if (selectedIndex >= 0 && selectedIndex < listView.Items.Count)
                {
                    var selectedItem = listView.Items[selectedIndex];
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
        }

        public void deleteVehicle(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                DeleteVehicle?.Invoke(index);
            }
        }

        public void SortItems(int columnIndex, SortOrder order)
        {
            listView1.ListViewItemSorter = new ListViewItemComparer(columnIndex, order);
            listView1.Sort();
        }
    }
}
