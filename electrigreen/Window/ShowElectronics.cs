using electrigreen.Functional;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electrigreen.Window
{
    public partial class ShowElectronics : Form
    {
        private static  List<Electronics> addedElectronics;
        private static string jsonFilePath = "ElectronicsData.json";

        public ShowElectronics()
        {
            // Inisialisasi komponen.
            InitializeComponent();

            // Mengambil data dari file json.
            LoadElectronicsFromJson();

            // Inisialisasi listbox.
            InitializeListBox();
        }

        public static void LoadElectronicsFromJson()
        {
            // Method ini mengambil data dari file json sebagai list Electronics dengan nama "addedElectronics".
            // Jika gagal dalam mengambil data, maka akan melempar exception berupa message ke console.
            try
            {
                string json = File.ReadAllText(jsonFilePath);
                addedElectronics = JsonConvert.DeserializeObject<List<Electronics>>(json) ?? new List<Electronics>();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void InitializeListBox()
        {
            // Method inisialisasi listbox akan menampilkan data-data nama dari list "addedElectronics".
            listBoxElectronics.Items.Clear();
            foreach (var electronics in addedElectronics)
            {
                listBoxElectronics.Items.Add(electronics.config.config.nama);
            }
        }

        private void listBoxElectronics_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ketika salah satu objek listbox ditekan, program akan memberikan detail dari isi objek yang ditekan dalam bentuk label.
            if (listBoxElectronics.SelectedIndex != -1)
            {
                var selectedElectronics = addedElectronics[listBoxElectronics.SelectedIndex];
                labelNama.Text = $"Nama: {selectedElectronics.config.config.nama}";
                labelMerk.Text = $"Merk: {selectedElectronics.config.config.merk}";
                labelVoltase.Text = $"Voltase: {selectedElectronics.config.config.voltase}";
                labelJenis.Text = $"Jenis: {selectedElectronics.config.config.jenis}";
                labelIsSmarthome.Text = $"Smarthome: {selectedElectronics.config.config.isSmarthome}";
            }
        }

        private void addElectronicsPageButton_Click(object sender, EventArgs e)
        {
            // Masuk ke halaman add electronics sebagai dialog.
            AddElectronics addElectronicsPage = new AddElectronics();
            addElectronicsPage.ShowDialog();
            LoadElectronicsFromJson();
        }
    }
}
