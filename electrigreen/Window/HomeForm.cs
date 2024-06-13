using electrigreen.Models;
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
    public partial class HomeForm : Form
    {
        public User user;
        public HomeForm(User user)
        {
            InitializeComponent();
            SapaUser(user);
            this.user = user;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            label18.Parent = pictureBox2;
            label17.Parent = pictureBox2;
            label19.Parent = pictureBox3;
            label20.Parent = pictureBox3;
            label21.Parent = pictureBox4;
            label22.Parent = pictureBox4;
            label18.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;
            label21.BackColor = Color.Transparent;
            label22.BackColor = Color.Transparent;
        }

        private void SapaUser(User user)
        {
            label16.Text = ("Selamat datang, " + user.Nama);
        }
    }
}
