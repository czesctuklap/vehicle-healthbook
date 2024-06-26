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
using VehicleHealthBook.Presenter;

namespace VehicleHealthBook.View
{
    public partial class Form4 : Form
    {
        private Form4Presenter presenter;

        public event EventHandler UpdateVehicle;
        public event EventHandler GoToVehicleList;

        public Form4(VehiclesList vList, Form1 form1, Vehicle vehicle)
        {
            InitializeComponent();
            presenter = new Form4Presenter(this, vList, form1, vehicle);
            this.FormClosing += Form4_FormClosing;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Set definitions
        public void SetProducer(string producer) => producerBox.Text = producer;
        public void SetModel(string model) => modelBox.Text = model;
        public void SetYearProduced(string yearProduced) => yearProducedBox.Text = yearProduced;
        public void SetLicenseNumber(string licenseNumber) => licenseNumberBox.Text = licenseNumber;
        public void SetMileage(string mileage) => mileageBox.Text = mileage;
        public void SetInsuranceDate(DateTime insuranceDate) => insuranceDatePicker.Value = insuranceDate;
        public void SetMotDate(DateTime motDate) => motDatePicker.Value = motDate;
        public void SetType(VehicleType type) => typeBox.SelectedItem = type.ToString();
        #endregion

        #region Get definitions
        public string GetProducer() => producerBox.Text;
        public string GetModel() => modelBox.Text;
        public string GetYearProduced() => yearProducedBox.Text;
        public string GetLicenseNumber() => licenseNumberBox.Text;
        public string GetMileage() => mileageBox.Text;
        public DateTime GetInsuranceDate() => insuranceDatePicker.Value;
        public DateTime GetMotDate() => motDatePicker.Value;
        public VehicleType GetType() => (VehicleType)Enum.Parse(typeof(VehicleType), typeBox.SelectedItem.ToString());
        #endregion

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateVehicle?.Invoke(this, EventArgs.Empty);
        }

        private void goToVehicleListButton_Click(object sender, EventArgs e)
        {
            GoToVehicleList?.Invoke(this, EventArgs.Empty);
        }
    }
}
