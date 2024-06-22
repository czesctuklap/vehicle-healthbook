using System;
using System.Windows.Forms;
using VehicleHealthBook.Model;
using VehicleHealthBook.Presenter;
using VehicleHealthBook.View;

namespace VehicleHealthBook.View
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Correctly initialize the VehiclesList and pass it to Form1 and Form2Presenter
            VehiclesList vehicleList = new VehiclesList();
            Form1 form1 = new Form1(vehicleList);  // Pass VehiclesList to Form1
            VehicleRepository repository = new VehicleRepository("Server=localhost;Database=vehivle_healthbook;User Id=root;Password=1234;");
            Form2 form2 = new Form2(vehicleList, form1);  // Pass VehiclesList and Form1 to Form2
            Form2Presenter presenter = new Form2Presenter(form2, vehicleList, form1);

            Application.Run(form1);
        }
    }
}
