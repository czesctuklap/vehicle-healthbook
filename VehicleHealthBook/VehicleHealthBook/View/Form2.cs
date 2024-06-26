using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleHealthBook.Model;
using VehicleHealthBook.Presenter;

namespace VehicleHealthBook.View
{
    public partial class Form2 : Form
    {

        // deklaracja eventu AddVehicle
        public event Action AddVehicle;
        private Form2Presenter presenter;
        private VehicleRepository repository;
        private VehiclesList _vehicleList;
        private Form1 _form1;
        public VehiclesList vehicleList
        {
            get => _vehicleList;
            set => _vehicleList = value;
        }
        public Form2(VehiclesList vList, Form1 form1)//()
        {
            InitializeComponent();
            //presenter = new Form2Presenter(this, repository);

            _vehicleList = vList;  // Ustawienie istniejącej listy pojazdów
            presenter = new Form2Presenter(this, vList, form1);  // Przekazanie referencji do Form1 do presenter
            _form1 = form1;
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public VehicleType getType()
        {
            string selectedType = typeBox.SelectedItem.ToString();
            if (Enum.TryParse(selectedType, out VehicleType type))
            {
                return type;
            }
            else
            {
                return 0;
            }
        }

        #region get definitions

        public string getProducer()
        {
            return producerBox.Text;
        }

        public string getModel()
        {
            return modelBox.Text;
        }

        public string getYear_produced()
        {
            return yearProducedBox.Text;
        }

        public string getLicense_number()
        {
            return licenseNumberBox.Text;
        }

        public string getMileage()
        {
            return mileageBox.Text;
        }

        public DateTime getInsurance_Date => insuranceDatePicker.Value;

        public DateTime getMot_Date => motDatePicker.Value;

        public string getName()
        {
            return nameBox.Text;
        }

        public string getSurname()
        {
            return surnameBox.Text;
        }

        #endregion

        #region action binds

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicle?.Invoke();
        }

        #endregion

        public void ClearForm()
        {
            producerBox.Text = "";
            modelBox.Text = "";
            yearProducedBox.Text = "";
            licenseNumberBox.Text = "";
            mileageBox.Text = "";
            insuranceDatePicker.Value = DateTime.Now;
            motDatePicker.Value = DateTime.Now;
            typeBox.SelectedIndex = -1;
        }
        public EventHandler goToVehicleList;
        private void goToForm1(object sender, EventArgs e)
        {
            goToVehicleList?.Invoke(this, EventArgs.Empty);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
