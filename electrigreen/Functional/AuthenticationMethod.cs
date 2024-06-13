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
        // Register Method
        public async void RegisterAction(User createUser)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:32768/swagger");
            HttpResponseMessage resMessage = await httpClient.PostAsJsonAsync("api/Auth/register", createUser);

            if (resMessage.IsSuccessStatusCode)
            {
                string resBodyRegister = await resMessage.Content.ReadAsStringAsync();
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


        // Get User to Local from API
        public async Task<User> GetUserByEmailAsync(string email)
        {
            string apiUrl = $"api/Auth/{email}";

            HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:32768/swagger") };
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
                    // Log error or handle it accordingly
                    Console.WriteLine($"JSON deserialization error: {ex.Message}");
                    return null;
                }
            }
            return null;
        }

        // Check login salting password
        public async Task<bool> ValidateUserAsync(string email, string password)
        {
            User user = await GetUserByEmailAsync(email);
            if (user != null)
            {
                return BCrypt.Net.BCrypt.Verify(password, user.Password);
            }
            return false;
        }

        // Check charcater for Email
        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
