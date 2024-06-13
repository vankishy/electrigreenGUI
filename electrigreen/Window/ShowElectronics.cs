using electrigreen.Functional;
using System;
using System.Windows.Forms;

namespace electrigreen.Window
{
    public partial class ShowElectronics : Form
    {
        private ElectronicsMediator mediator;

        public ShowElectronics()
        {
            //Inisialisasi komponen.
            InitializeComponent();

            //Mengambil data dari file json.
            mediator = new ElectronicsMediator();

            //Inisialisasi listbox.
            InitializeListBox();
        }

        private void InitializeListBox()
        {
            // Method inisialisasi listbox akan menampilkan data-data nama dari list "addedElectronics".
            listBoxElectronics.Items.Clear();
            foreach (var electronics in mediator.GetElectronicsList())
            {
                listBoxElectronics.Items.Add(electronics.config.config.nama);
            }
        }

        private void listBoxElectronics_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ketika salah satu objek listbox ditekan, program akan memberikan detail dari isi objek yang ditekan dalam bentuk label.
            if (listBoxElectronics.SelectedIndex != -1)
            {
                var selectedElectronics = mediator.GetElectronicsList()[listBoxElectronics.SelectedIndex];
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
            AddElectronics addElectronicsPage = new AddElectronics(mediator, this);
            addElectronicsPage.ShowDialog();
            RefreshList();
        }

        public void RefreshList()
        {
            //Merefresh data pada List
            InitializeListBox();
        }
    }
}
