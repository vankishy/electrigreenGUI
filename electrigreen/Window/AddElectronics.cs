using electrigreen.Functional;
using electrigreen.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace electrigreen.Window
{
    public partial class AddElectronics : Form
    {
        private ElectronicsMediator mediator;
        private ShowElectronics showElectronics;

        public AddElectronics(ElectronicsMediator mediator, ShowElectronics showElectronics)
        {
            //Inisialisasi Komponen
            InitializeComponent();
            this.mediator = mediator;
            this.showElectronics = showElectronics;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Menambahkan Alat Elektronik saat tombol add ditekan
            AddNewElectronic();

            //Menjalankan Method untuk membuat notifikasi
            NotifyPerangkatAdded();

            //Membersihkan Form saat telah di add
            ClearFormFields();

            //Merefresh list pada kelas ShowEltronics
            showElectronics.RefreshList();
        }

        private void AddNewElectronic()
        {
            //Mengambil data pada textBox lalu memproses data pada mediator untuk dimasukan kedalam JSON
            string nama = textBoxNama.Text;
            string jenis = comboBoxJenisPerangkat.Text;
            string merk = textBoxMerk.Text;
            string voltaseString = textBoxVoltase.Text;
            bool isSmarthome = checkBoxIsSmarthome.Checked;

            if (!CheckValiditasInput(nama, merk, voltaseString, jenis))
            {
                return;
            }

            int voltase = int.Parse(voltaseString);
            ElectronicsAddConfig configData = new ElectronicsAddConfig(nama, jenis, merk, voltase, isSmarthome);
            ElectronicsConfig electronicsConfig = new ElectronicsConfig { config = configData };
            Electronics newElectronics = new Electronics(electronicsConfig, mediator);

            mediator.AddElectronic(newElectronics);
        }

        private bool CheckValiditasInput(string nama, string merk, string voltase, string jenis)
        {
            //Secure Code: Mengetes dan memastikan input sesuai dengan Design by Contract
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
            //Mengosongkan seluruh medium input
            textBoxNama.Text = string.Empty;
            textBoxMerk.Text = string.Empty;
            textBoxVoltase.Text = string.Empty;
            comboBoxJenisPerangkat.SelectedIndex = -1;
            comboBoxJenisPerangkat.Text = string.Empty;
            checkBoxIsSmarthome.Checked = false;
        }

        private void NotifyPerangkatAdded()
        {
            //Mengambil seluruh data lalu membuat notifikasi sesuai format
            string nama = textBoxNama.Text;
            string jenis = comboBoxJenisPerangkat.Text;
            bool isSmarthome = checkBoxIsSmarthome.Checked;
            NotifikasiBerhasil.Icon = Properties.Resources.light_bulb_icon_126685;
            NotifikasiBerhasil.Text = "Perangkat Berhasil Ditambah";
            NotifikasiBerhasil.Visible = true;
            NotifikasiBerhasil.BalloonTipTitle = "Perangkat Berhasil Ditambah";
            NotifikasiBerhasil.BalloonTipText = isSmarthome
                ? $"Perangkat smarthome {jenis} {nama} berhasil ditambahkan."
                : $"Perangkat non-smarthome {jenis} {nama} berhasil ditambahkan.";
            NotifikasiBerhasil.ShowBalloonTip(100);
        }
    }
}