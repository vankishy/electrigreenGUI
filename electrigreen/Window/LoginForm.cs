
using electrigreen.Window;
using electrigreen.Models;
using System.Diagnostics;
using System.Net.Http.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using electrigreen.Core;

namespace electrigreen.Window
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Event handler untuk klik label "Register"
        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false; // Menyembunyikan form login saat ini
            RegisterForm registerForm = new RegisterForm(); // Membuat instance dari RegisterForm
            registerForm.Show(); // Menampilkan form register
        }

        // Event handler untuk klik tombol "Login"
        private async void authButton1_Click(object sender, EventArgs e)
        {
            string email = authTextBox1.Text; // Mendapatkan email dari text box
            string password = authTextBox2.Text; // Mendapatkan password dari text box

            AuthenticationMethod authen = new AuthenticationMethod(); // Membuat instance dari AuthenticationMethod

            // Validasi format email
            if (!authen.IsValidEmail(email))
            {
                MessageBox.Show("Format email tidak valid."); // Menampilkan pesan kesalahan jika email tidak valid
                return;
            }

            try
            {
                // Memverifikasi pengguna secara asinkron
                bool isAuthenticated = await authen.ValidateUserAsync(email, password);

                if (isAuthenticated)
                {
                    // Mendapatkan informasi pengguna jika autentikasi berhasil
                    User user = await authen.GetUserByEmailAsync(email);
                    this.Visible = false; // Menyembunyikan form login saat ini
                    MainForm mainForm = new MainForm(user); // Membuat instance dari MainForm dengan parameter user
                    mainForm.Show(); // Menampilkan form utama
                }
                else
                {
                    MessageBox.Show("Gagal Login, Email atau Password salah."); // Menampilkan pesan kesalahan jika autentikasi gagal
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan kesalahan jika terjadi exception
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}

