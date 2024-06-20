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
    public partial class Form1 : Form
    {
        public VehiclesList vehicleList = new VehiclesList();
        private Form1Presenter presenter;
        public event EventHandler<ColumnClickEventArgs> ColumnHeaderClicked;
        public Form1()
        {
            InitializeComponent();
            presenter = new Form1Presenter(this, new VehiclesList());
            listView1.ColumnClick += (sender, e) => ColumnHeaderClicked?.Invoke(sender, e);
            listView1.Items.Add(new ListViewItem(new[] { "Producer1", "Model1", "2020", "ABC123", "10000", "01/01/2022", "01/01/2023", "Type1" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer2", "Model2", "2019", "DEF456", "20000", "01/01/2021", "01/01/2022", "Type2" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer3", "Model3", "2018", "GHI789", "30000", "01/01/2020", "01/01/2021", "Type3" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer4", "Model4", "2017", "JKL012", "40000", "01/01/2019", "01/01/2020", "Type4" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer5", "Model5", "2016", "MNO345", "50000", "01/01/2018", "01/01/2019", "Type5" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer6", "Model6", "2015", "PQR678", "60000", "01/01/2017", "01/01/2018", "Type6" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer7", "Model7", "2014", "STU901", "70000", "01/01/2016", "01/01/2017", "Type7" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer8", "Model8", "2013", "VWX234", "80000", "01/01/2015", "01/01/2016", "Type8" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer9", "Model9", "2012", "YZA567", "90000", "01/01/2014", "01/01/2015", "Type9" }));
            listView1.Items.Add(new ListViewItem(new[] { "Producer10", "Model10", "2011", "BCD890", "100000", "01/01/2013", "01/01/2014", "Type10" }));
            listView1.DoubleClick += ItemDoubleClick; 

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
                    string producer= selectedItem.SubItems[0].Text;
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
