using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using VehicleHealthBook.Model;

namespace VehicleHealthBook.Model
{
    public class VehiclesList
    {
        public List<Vehicle> list = new List<Vehicle>();
        public List<Vehicle> filtered = new List<Vehicle>();

        public void Serialize()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik XML|*.xml|Wszystkie pliki|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Vehicle>));
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    xml.Serialize(fileStream, list);
                }
            }
        }

        public void Deserialize()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                list.Clear();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>), new XmlRootAttribute("ArrayOfVehicle"));
                using (Stream reader = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    var x = (List<Vehicle>)serializer.Deserialize(reader);
                    foreach (Vehicle p in x)
                    {
                        list.Add(p);
                    }
                }
            }
        }

        public void Sort()
        {
            // Implement sorting logic
        }

        public void Filter(string filter, string value)
        {
            // Implement filtering logic
        }

        public void Filter(string filter, DateTime value)
        {
            // Implement filtering logic
        }

        public VehiclesList()
        {
            // Inicjalizacja listy wydarzeń, jeśli to konieczne
        }

    }
}