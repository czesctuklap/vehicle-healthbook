using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
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

            string connectionString = "Server=localhost;Database=vehivle_healthbook;User Id=root;Password=1234;";
            VehicleRepository repository = new VehicleRepository(connectionString);
            Form2 view = new Form2();
            Form2Presenter presenter = new Form2Presenter(view, repository);

            Application.Run(new View.Form2());
        }
    }
}
