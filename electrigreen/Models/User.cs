using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electrigreen.Models
{
    // Model untuk merepresentasikan data pengguna
    public class User
    {
        // Nama pengguna
        public string Nama { get; set; }

        // Email pengguna
        public string Email { get; set; }

        // Password pengguna
        public string Password { get; set; }
    }

    // Model untuk merepresentasikan data login
    public class LoginModel
    {
        // Email untuk login
        public string Email { get; set; }

        // Password untuk login
        public string Password { get; set; }
    }
}

