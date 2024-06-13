using electrigreen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electrigreen.Window
{
    public partial class ArtikelForm : Form
    {
        public ArtikelForm()
        {
            InitializeComponent();
        }

        private void ARTIKEL1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsiArtikel IA = new IsiArtikel(1);
            IA.ShowDialog();
            this.Show();
        }

        private void ARTIKEL2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsiArtikel IA = new IsiArtikel(2);
            IA.ShowDialog();
            this.Show();
        }

        private void ARTIKEL3_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsiArtikel IA = new IsiArtikel(3);
            IA.ShowDialog();
            this.Show();
        }

        private void ARTIKEL4_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsiArtikel IA = new IsiArtikel(4);
            IA.ShowDialog();
            this.Show();
        }
    }
}

