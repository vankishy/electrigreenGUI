using electrigreen.Functional;
using electrigreen.Window;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace electrigreen.Functional
{
    public interface IElectronicsMediator
    {
        void AddElectronic(Electronics electronics);
        void ActivateTrigger(Electronics electronic, Trigger trigger);
        List<Electronics> GetElectronicsList();
        void LoadFromJson(string filePath);
        void SaveToJson(string filePath);
    }

    public class ElectronicsMediator : IElectronicsMediator
    {
        private List<Electronics> electronicsList;
        private readonly string jsonFilePath = "ElectronicsData.json";

        public ElectronicsMediator()
        {
            electronicsList = new List<Electronics>();
            LoadFromJson(jsonFilePath);
        }

        public void AddElectronic(Electronics electronic)
        {
            electronicsList.Add(electronic);
            SaveToJson(jsonFilePath);
        }

        public void ActivateTrigger(Electronics electronic, Trigger trigger)
        {
            electronic.ActivateTrigger(trigger);
        }

        public List<Electronics> GetElectronicsList()
        {
            return electronicsList;
        }

        public void LoadFromJson(string filePath)
        {
            // Method ini mengambil data dari file json sebagai list Electronics dengan nama "addedElectronics".
            // Jika gagal dalam mengambil data, maka akan melempar exception berupa message ke console.
            try
            {
                if (File.Exists(filePath))
                {
                    
                    string json = File.ReadAllText(filePath);
                    electronicsList = JsonConvert.DeserializeObject<List<Electronics>>(json) ?? new List<Electronics>();
                }
                else
                {
                    electronicsList = new List<Electronics>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                electronicsList = new List<Electronics>();
            }
        }

        public void SaveToJson(string filePath)
        {
            try
            {
                MessageBox.Show(filePath, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string json = JsonConvert.SerializeObject(electronicsList, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}