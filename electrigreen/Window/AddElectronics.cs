using electrigreen.Functional;
using electrigreen.Models;
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
    public partial class AddElectronics : Form
    {
        private ElectronicsMediator mediator;
        private ShowElectronics showElectronics;
        private List<Electronics> addedElectronics = new List<Electronics>();

        public AddElectronics(ShowElectronics showElectronics)
        {
            InitializeComponent();
            mediator = new ElectronicsMediator();
            this.showElectronics = showElectronics;
            addedElectronics = ReadElectronicsFromJson();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string merk = textBox2.Text;
            string voltaseString = textBox3.Text;
            string jenis = comboBox1.Text;
            bool isSmarthome = checkBox1.Checked;

            if (!checkValiditasInput(nama, merk, voltaseString, jenis))
            {
                return;
            }
            int voltase = int.Parse(voltaseString);

            ElectronicsAddConfig configData = new ElectronicsAddConfig(nama, jenis, merk, voltase, isSmarthome);

            ElectronicsConfig electronicsConfig = new ElectronicsConfig { config = configData };
            Electronics newElectronics = new Electronics(electronicsConfig, mediator);

            addedElectronics.Add(newElectronics);
            mediator.AddElectronic(newElectronics);


            NotifyPerangkatAdded(nama, isSmarthome, jenis);
            ClearFormFields();
            WriteElectronicsToJson();
            showElectronics.RefreshList();
        }

        private bool checkValiditasInput(string nama, string merk, string voltase, string jenis)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nama))
                {
                    throw new ArgumentException("Form nama Harus Diisi.");
                }

                if (string.IsNullOrWhiteSpace(merk))
                {
                    throw new ArgumentException("Form merk Harus Diisi.");
                }

                if (string.IsNullOrWhiteSpace(voltase))
                {
                    throw new ArgumentException("Form voltase Harus Diisi.");
                }

                if (string.IsNullOrWhiteSpace(jenis))
                {
                    throw new ArgumentException("Form jenis Harus Diisi.");
                }

                if (!int.TryParse(voltase, out int voltaseAngka))
                {
                    throw new ArgumentException("Voltase harus berupa angka.");
                }

                // If all checks pass, return true
                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void ClearFormFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
        }

        private void WriteElectronicsToJson()
        {
            string jsonFilePath = "ElectronicsData.json";

            string json = JsonConvert.SerializeObject(addedElectronics, Newtonsoft.Json.Formatting.Indented);

            // Write JSON to file
            File.WriteAllText(jsonFilePath, json);
        }
        private List<Electronics> ReadElectronicsFromJson()
        {
            string jsonFilePath = "ElectronicsData.json";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<Electronics>>(json) ?? new List<Electronics>();
            }
            else
            {
                return new List<Electronics>();
            }
        }

        private void NotifyPerangkatAdded(String nama, bool isSmarthome, String jenis)
        {
            NotifikasiBerhasil.Icon = Properties.Resources.light_bulb_icon_126685;
            NotifikasiBerhasil.Text = "Perangkat Berhasil Ditambah";
            NotifikasiBerhasil.Visible = true;
            NotifikasiBerhasil.BalloonTipTitle = "Perangkat Berhasil Ditambah";
            if (isSmarthome)
            {

                NotifikasiBerhasil.BalloonTipText = $"Perangkat smarthome {jenis} {nama} berhasil ditambahkan.";
            }
            else
            {

                NotifikasiBerhasil.BalloonTipText = $"Perangkat non-smarthome {jenis} {nama} berhasil ditambahkan.";
            }
            NotifikasiBerhasil.ShowBalloonTip(100);
        }
    }
}

