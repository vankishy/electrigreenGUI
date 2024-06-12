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
    public partial class IsiArtikel : Form
    {
        private int selectedArticle = 0;

        public IsiArtikel()
        {
            InitializeComponent();
        }

        public void SetArticle(int articleNumber)
        {
            selectedArticle = articleNumber;
        }

        private void IsiArtikel_Load(object sender, EventArgs e)
        {
            DisplayArticle();
        }

        private void DisplayArticle()
        {
            string paragraph = string.Empty;

            switch (selectedArticle)
            {
                case 1:
                    paragraph = "1. Tidak Seluruhnya Perangkat Pintar Kompatibel\r\nTidak menutup kemungkinan berbagai perangkat dalam sistem smart home, tidak kompatibel atau tidak sesuai antara satu dan lainnya. Beberapa perangkat pintar terkadang membutuhkan tenaga ahli untuk proses instalasinya agar dapat digunakan secara optimal.\r\n\r\nBergantung pada Jaringan dan Koneksi Internet\r\n\r\nPemakaian sistem smart home sangat mengandalkan pada koneksi internet yang lancar dan stabil. Apabila terjadi gangguan (down) internet, dapat mengganggu kinerja smart home hingga koneksinya kembali stabil.\r\n\r\nMeskipun demikian, tidak semua perangkat pintar bergantung pada internet/WiFi sepenuhnya. Ada beberapa perangkat yang masih bisa berfungsi meskipun tidak terhubung dengan internet, misalnya smart lock non-wifi. \r\n\r\n2. Biaya Pemasangan Relatif Mahal\r\nSeperti yang sudah disinggung sebelumnya, biaya untuk pemasangan smart home relatif mahal dan terkadang membutuhkan ahli profesional. Belum lagi untuk harga setiap produk yang digunakan dalam sistem smart home, yang cenderung pricey. \r\n\r\nBerbeda dengan seluruh produk smart living dari Onassis & Othentica yang harganya affordable dan pemasangannya mudah dan bisa dilakukan sendiri dengan menonton tutorial pemasangannya di YouTube channel Onassis Official.\r\n\r\n3. Risiko Kegagalan Teknis pada Perangkat\r\nKekurangan smart home berikutnya adalah adanya risiko kegagalan teknis pada sistem smart home. Perangkat apapun berbasis teknologi memiliki potensi alami kerusakan fisik maupun sistem apabila tidak di-maintain dengan baik dalam waktu yang cukup lama.";
                    break;
                case 2:
                    paragraph = "Smart home, atau yang juga dikenal dengan rumah pintar, adalah sebuah konsep rumah yang mengadopsi teknologi canggih untuk meningkatkan kualitas hidup penghuninya.\\r\\n\\r\\nDalam rumah pintar, berbagai perangkat dan sistem yang ada di dalam rumah, seperti pencahayaan, pengendali suhu, sistem keamanan, hingga perangkat elektronik, dapat dikontrol dan dipantau secara otomatis atau jarak jauh melalui perangkat pintar seperti smartphone atau tablet.\\r\\n\\r\\nSelain itu, sistem ini juga memungkinkan perangkat-perangkat tersebut saling terhubung dan beroperasi sesuai dengan kebutuhan atau preferensi penghuni rumah.\\r\\n\\r\\nKonsep smart home erat kaitannya dengan teknologi Internet of Things (IoT). IoT adalah jaringan yang menghubungkan berbagai perangkat fisik, seperti sensor, perangkat elektronik, dan perangkat lainnya yang dilengkapi dengan teknologi internet untuk bertukar data dan berinteraksi satu sama lain.\\r\\n\\r\\nDalam konteks smart home, IoT memungkinkan perangkat-perangkat di dalam rumah beroperasi secara otomatis atau dapat dikendalikan dari jarak jauh.\\r\\n\\r\\nMisalnya, lampu bisa otomatis menyala ketika sensor mendeteksi bahwa ruangan sudah mulai gelap, atau AC bisa otomatis menyesuaikan suhu ruangan berdasarkan data dari sensor suhu.\\r\\n\\r\\nKomponen utama dari smart home meliputi perangkat keras (hardware), perangkat lunak (software), dan jaringan komunikasi.\\r\\n\\r\\nPerangkat keras meliputi berbagai perangkat dan sistem yang ada di rumah, seperti lampu, AC, sistem keamanan, dan perangkat elektronik lainnya yang telah dilengkapi dengan teknologi IoT.\\r\\n\\r\\nPerangkat lunak, di sisi lain, adalah aplikasi atau platform yang digunakan untuk mengontrol dan memantau operasi dari perangkat-perangkat tersebut. Ini bisa berupa aplikasi mobile di smartphone atau tablet, atau software di komputer.\r\n";
                    break;
                case 3:
                    paragraph = "Di zaman yang serba canggih ini banyak sekali teknologi - teknologi yang sangat mempermudah manusia salah satunya adalah Smart Home, rumah yang sangat canggih karena menggunakan alat - alat cerdas yang telah di hubungkan ke sistem control, tidak bisa dipungkiri bahwa zaman sekarang smart home menjadi rumah impian bagi semua orang.\\r\\n\\r\\nRumah yang canggih ini begitu banyak memberikan kenyamanan dan kemudahan karena kita bisa mengcontrol rumah dan menyeting apapun yang ada di rumah sesuai dengan keinginan dan kebutuhan kita, misalnya : kapan lampu harus mati, kapan gerbang rumah harus di buka, kapan jendela rumah harus ditutup, kapan ac harus dimatikan dan masih banyak yang lainnya.\\r\\n\\r\\nSeorang konten creator tiktok @rumahsmd sering membagikan konten- konten dirinya yang menggunakan smart home, konten creator ini telah menggunakan smart home karena menurutnya itu sangat efisien, memudahkan dan tidak membuang - buang waktu dan dia juga menerangkan bahwa menggunakan smart home tidak semahal yang terbayangkan, dan juga barang - barang yang dipakai tidak semuanya menggunakan listrik, ada juga yang menggunakan baterai, seperti gembok pagar rumah, smart door lock, alat untuk gorden, dan lainnya, banyak alat smart home yang menggunakan baterai jadi tidak semua alat smart home menggunakan listrik.\\r\\n\\r\\nTentu saja smart home disebut - sebut dengan house goals karena kenyamanan dan kemudahannya sangat membantu pekerjaan seorang ibu rumah tangga, tetapi banyak orang yang masih ragu untuk memakai smart home, karena smart home pasti banyak menggunakan listrik dan juga khawatir ketika listrik mati maka semua barang tidak berfungsi, padahal ketika tidak ada listrik kita masih bisa menggunakan alat rumah dengan cara manual.\r\n";
                    break;
                case 4:
                    paragraph = "Pesatnya perkembangan teknologi yang semakin canggih membuat sesuatu yang tadinya tidak mungkin ada menjadi mungkin terjadi. Seiring dengan perkembangan zaman yang semakin modern, kita tidak hanya dapat menemukan smartphone dengan teknologi super canggih namun juga dapat menemukan kehadiran smart home. Smart home system atau teknologi rumah pintar, mengacu pada pengaturan rumah yang nyaman dimana peralatan dan perangkat dapat dikontrol secara otomatis dari jarak jauh atau dari mana saja dengan koneksi internet. Sistem ini menggunakan perangkat seluler atau perangkat jaringan lainnya. Smart home system memungkinkan pengguna untuk mengontrol fungsi seperti akses keamanan ke rumah, suhu, pencahayaan, dan home theater dari jarak jauh. Sistem ini dibuat agar pemilik rumah menjadi lebih mudah dan nyaman mengatur rumahnya dan juga membantu penghematan biaya. Namun, smart home system juga tetap memiliki risiko keamanan dan bug, sehingga pemilik rumah harus selalu memantau dan memperbarui sistemnya.\\r\\n\\r\\n Seperti namanya, smart home atau rumah pintar merupakan tempat tinggal berbasis teknologi sehingga semua peralatan rumah dapat diatur dan terpusat pada satu tempat sehingga dapat dikendalikan jarak jauh maupun dekat. Smart home dilengkapi dengan sistem pengelolaan rumah dengan teknologi yang canggih sehingga berbagai peralatan listrik hingga elektronik dapat dikontrol dengan bantuan internet. Smart home system inilah yang akan memberikan kemudahan dan kenyaman bagi penggunanya. \r\n";
                    break;
                default:
                    paragraph = "Artikel tidak ditemukan.";
                    break;
            }

            ISIANARTIKEL.Text = paragraph;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Tidak diperlukan penanganan di sini untuk perubahan teks.
        }
    }
}
