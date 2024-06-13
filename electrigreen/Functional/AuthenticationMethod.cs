using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using electrigreen.Models;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace electrigreen.Core
{
    public class AuthenticationMethod
    {
        // Metode untuk melakukan registrasi pengguna baru
        public async void registerAction(Models.User createUser)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:5263");
            HttpResponseMessage resMessage = await httpClient.PostAsJsonAsync("api/Auth/register", createUser);

            if (resMessage.IsSuccessStatusCode)
            {
                string resBodyRegister = await resMessage.Content.ReadAsStringAsync();
                // Arahkan ke Form Login jika registrasi berhasil
            }
            else if (resMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                string errMessage = await resMessage.Content.ReadAsStringAsync();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(errMessage, "Bad Request", buttons, MessageBoxIcon.Error);
            }
            else
            {
                string errMessage = await resMessage.Content.ReadAsStringAsync();
                if (errMessage.Contains("hasBeenUsed"))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Email sudah terdaftar, Coba lagi!", "Galat", buttons, MessageBoxIcon.Warning);
                    Console.WriteLine("Email sudah terdaftar, Coba lagi!");
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Gagal mendaftarkan akun, Error: " + resMessage.StatusCode, "Error", buttons, MessageBoxIcon.Error);
                }
            }
        }

        // Metode untuk mendapatkan pengguna berdasarkan email secara asinkron
        public async Task<User> GetUserByEmailAsync(string email)
        {
            string apiUrl = $"api/Auth/{email}";

            HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5263") };
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                try
                {
                    return JsonConvert.DeserializeObject<User>(jsonResponse);
                }
                catch (System.Text.Json.JsonException ex)
                {
                    // Log kesalahan atau tangani sesuai kebutuhan
                    Console.WriteLine($"Kesalahan deserialisasi JSON: {ex.Message}");
                    return null;
                }
            }
            return null;
        }

        // Metode untuk memvalidasi pengguna berdasarkan email dan password secara asinkron
        public async Task<bool> ValidateUserAsync(string email, string password)
        {
            User user = await GetUserByEmailAsync(email);
            if (user != null)
            {
                // Memverifikasi password menggunakan BCrypt
                return BCrypt.Net.BCrypt.Verify(password, user.Password);
            }
            return false;
        }

        // Metode untuk memvalidasi format email
        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|co\.id|ac\.id|org)$";
            return Regex.IsMatch(email, emailPattern);
        }

        public bool IsValidPassword(string password)
        {
            // Panjang password harus antara 8 hingga 15 karakter
            if (password.Length < 8 || password.Length > 15)
            {
                return false;
            }

            // Pola regex untuk memvalidasi password
            // ^              : Awal string
            // (?=.*[A-Z])    : Harus mengandung setidaknya satu huruf besar
            // (?=.*[!@#$%^&*(),.?":{}|<>]) : Harus mengandung setidaknya satu simbol
            // (?=.*[0-9])    : Harus mengandung setidaknya satu angka
            // (?=.*[a-z])    : Harus mengandung setidaknya satu huruf kecil
            // .{7,14}        : Harus memiliki panjang 7 hingga 14 karakter (karena karakter pertama sudah diperiksa secara terpisah)
            // $              : Akhir string
            string pattern = @"^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*(),.?""':{}|<>]).{7,14}$";

            // Periksa apakah karakter pertama adalah huruf besar
            if (!char.IsUpper(password[0]))
            {
                return false;
            }

            // Gunakan Regex untuk memvalidasi sisa password
            return Regex.IsMatch(password.Substring(1), pattern);
        }
    }
}

