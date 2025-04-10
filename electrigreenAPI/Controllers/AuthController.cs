using electrigreenAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace electrigreenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private const string filePath = "accRecord.json";
        private List<RegisterModel> _users;

        // Constructor untuk menginisialisasi data pengguna
        public AuthController()
        {
            GetRecord();
        }

        // Add comment sikit2 saja
        // Metode untuk membaca data pengguna dari file JSON
        private void GetRecord()
        {
            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);
                _users = JsonSerializer.Deserialize<List<RegisterModel>>(json);
            }
            else
            {
                _users = new List<RegisterModel>();
            }
        }

        // Metode untuk menyimpan data pengguna ke file JSON
        private void SaveRecord()
        {
            string json = JsonSerializer.Serialize(_users);
            System.IO.File.WriteAllText(filePath, json);
        }

        // Endpoint untuk mendapatkan semua pengguna
        [HttpGet]
        public IActionResult GetUser()
        {
            if (_users.Count == 0)
            {
                return Ok("Data kosong!!");
            }

            return Ok(_users);
        }

        // Endpoint untuk mendaftarkan pengguna baru
        [HttpPost("register")]
        public IActionResult Register(RegisterModel model)
        {
            // Validasi model
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (string.IsNullOrWhiteSpace(model.nama))
            {
                throw new ArgumentException("Nama harus diisi terlebih dahulu!!", nameof(model.nama));
            }

            if (string.IsNullOrWhiteSpace(model.email))
            {
                throw new ArgumentException("Email wajib diisi!!", nameof(model.email));
            }

            if (string.IsNullOrWhiteSpace(model.password))
            {
                throw new ArgumentException("Password harus diisi", nameof(model.password));
            }

            // Cek apakah email sudah digunakan
            if (_users.Any(u => u.email == model.email))
            {
                return Conflict("Email sudah digunakan");
            }

            // Tambahkan pengguna baru dan simpan ke file
            _users.Add(model);
            SaveRecord();

            if (!_users.Contains(model))
            {
                throw new Exception("Registrasi gagal");
            }
            return Ok("Akun terdaftar");
        }

        // Endpoint untuk login pengguna
        [HttpPost("Login")]
        public IActionResult Login(LoginModel model)
        {
            // Validasi model login
            if (model == null)
            {
                return BadRequest("Invalid login request");
            }

            // Cek kredensial pengguna
            var user = _users.FirstOrDefault(u => u.email.Equals(model.email, StringComparison.OrdinalIgnoreCase) && u.password == model.password);

            if (user != null)
            {
                return Ok("Selamat datang " + model.email);
            }
            else
            {
                return Conflict("Email atau Password Salah");
            }
        }

        // Endpoint untuk mendapatkan pengguna berdasarkan email
        [HttpGet("{email}")]
        public IActionResult GetUserByEmail(string email)
        {
            // Validasi email
            if (string.IsNullOrWhiteSpace(email))
            {
                return BadRequest("Email harus diisi");
            }

            // Cari pengguna berdasarkan email
            var user = _users.FirstOrDefault(u => u.email.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound("Pengguna tidak ditemukan");
            }
        }
    }
}

