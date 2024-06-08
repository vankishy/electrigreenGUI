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

        private List<Electronics> addedElectronics = new List<Electronics>();

        public AddElectronics()
        {
            InitializeComponent();
            mediator = new ElectronicsMediator();

            comboBox1.Items.AddRange(new String[]
            {

            });
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
        }

        private bool checkValiditasInput(string nama, string merk, string voltase, string jenis)
        {
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Form nama Harus Diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(merk))
            {
                MessageBox.Show("Form merk Harus Diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(voltase))
            {
                MessageBox.Show("Form voltase Harus Diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(jenis))
            {
                MessageBox.Show("Form jenis Harus Diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(voltase, out int voltaseAngka))
            {
                MessageBox.Show("Voltase harus berupa angka.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        private void NotifyPerangkatAdded(String nama, bool isSmarthome, String jenis)
        {
            NotifikasiBerhasil.Icon = new System.Drawing.Icon(Path.GetFullPath("light_bulb_icon_126685.ico"));
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

