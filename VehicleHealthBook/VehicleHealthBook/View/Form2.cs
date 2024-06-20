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
        public Form2()
        {
            InitializeComponent();
            presenter = new Form2Presenter(this, repository);
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
    }
}
