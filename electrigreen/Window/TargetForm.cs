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
    public partial class TargetForm : Form
    {
        public TargetForm()
        {
            InitializeComponent();
            inisiasiAchivment();
            inisiasiRank();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Hitung jumlah item yang telah dicentang sebelum perubahan
            int checkedCountBefore = checkedListBox1.CheckedItems.Count;

            // Periksa apakah item tersebut akan dicentang atau tidak
            if (e.NewValue == CheckState.Checked)
            {
                // Tambahkan nilai ProgressBar berdasarkan penambahan item
                progressBar1.Value += progressBar1.Maximum / 10;
                if ((float)progressBar1.Value / progressBar1.Maximum >= 0.8)
                {
                    pictureBox1.BackgroundImage = Properties.Resources.rankSilver; // Ganti ikon menjadi silver rank
                    label3.Text = "Silver";
                }
                // Cek apakah ProgressBar mencapai 100%
                if ((float)progressBar1.Value / progressBar1.Maximum >= 1.0)
                {
                    pictureBox1.BackgroundImage = Properties.Resources.rankGold; // Ganti ikon menjadi gold rank
                    label3.Text = "Gold";
                }
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // Kurangi nilai ProgressBar berdasarkan pengurangan item
                progressBar1.Value -= progressBar1.Maximum / 10;
                if ((float)progressBar1.Value / progressBar1.Maximum >= 0.8)
                {
                    pictureBox1.BackgroundImage = Properties.Resources.rankSilver; // Ganti ikon menjadi silver rank
                    label3.Text = "Silver";
                }

                if ((float)progressBar1.Value / progressBar1.Maximum < 0.8)
                {
                    pictureBox1.BackgroundImage = Properties.Resources.rankBronze; // Ganti ikon menjadi rank bronze
                    label3.Text = "Bronze";
                }
            }

            // Pastikan nilai ProgressBar tidak melebihi nilai maksimum atau kurang dari 0
            progressBar1.Value = Math.Max(0, Math.Min(progressBar1.Value, progressBar1.Maximum));

            // Hitung jumlah item yang telah dicentang setelah perubahan
            int checkedCountAfter = checkedCountBefore + ((e.NewValue == CheckState.Checked) ? 1 : -1);

            // Perbarui teks pada ProgressBar
            progressBar1.Text = $"{progressBar1.Value} / {progressBar1.Maximum}";

            // Aktifkan atau nonaktifkan ProgressBar berdasarkan jumlah item yang dicentang
            progressBar1.Enabled = (checkedCountAfter > 0);
        }

        private void SetItemEnabled(int index, bool enabled)
        {
            
        }

        private void inisiasiAchivment()
        {
            checkedListBox1.Items.Add("Mencabut charger yang tidak digunakan");
            checkedListBox1.Items.Add("Mematikan TV jika tidak ada yang menonton TV");
            checkedListBox1.Items.Add("Matikan lampu saat tidur malam");
            checkedListBox1.Items.Add("Gunakan pengatur waktu untuk lampu");
            checkedListBox1.Items.Add("Gunakan kipas angin sebagai alternatif AC");
            checkedListBox1.Items.Add("Periksa dan tutup kebocoran pada pintu dan jendela");
            checkedListBox1.Items.Add("Ganti lampu pijar dengan lampu LED");
            checkedListBox1.Items.Add("Gunakan alat elektronik dengan efisien");
            checkedListBox1.Items.Add("Matikan perangkat elektronik saat tidak digunakan");
            checkedListBox1.Items.Add("Edukasi keluarga tentang penghematan energi");
        }

        private void inisiasiRank()
        {
            pictureBox1.BackgroundImage = Properties.Resources.rankBronze;
            label3.Text = "Bronze";
        }
    }
}
