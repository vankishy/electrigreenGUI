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
    public partial class MainForm : Form
    {
        public User user;
        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            loadform(new HomeForm(user));
        }
        public void loadform(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(fh);
            this.mainPanel.Tag = fh;
            fh.Show();
        }

        // Home Button
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new HomeForm(user));
            button2.Image = Properties.Resources.Home__On__28;
            button3.Image = Properties.Resources.Lightbulb_Filament__Off__28;
            button5.Image = Properties.Resources.Target_Arrow__Off__28;
            button7.Image = Properties.Resources.Feed__Off__28;
            button2.ForeColor = Color.FromArgb(94, 143, 51);
            button3.ForeColor = Color.FromArgb(0, 0, 0);
            button5.ForeColor = Color.FromArgb(0, 0, 0);
            button7.ForeColor = Color.FromArgb(0, 0, 0);

        }

        // Perangkat Button
        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new ShowElectronics());
            button2.Image = Properties.Resources.Home__Off__28;
            button3.Image = Properties.Resources.Lightbulb_Filament__On__28;
            button5.Image = Properties.Resources.Target_Arrow__Off__28;
            button7.Image = Properties.Resources.Feed__Off__28;
            button3.ForeColor = Color.FromArgb(94, 143, 51);
            button2.ForeColor = Color.FromArgb(0, 0, 0);
            button5.ForeColor = Color.FromArgb(0, 0, 0);
            button7.ForeColor = Color.FromArgb(0, 0, 0);
        }

        // Target Button
        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new TargetForm());
            button2.Image = Properties.Resources.Home__Off__28;
            button3.Image = Properties.Resources.Lightbulb_Filament__Off__28;
            button5.Image = Properties.Resources.Target_Arrow__On__28;
            button7.Image = Properties.Resources.Feed__Off__28;
            button5.ForeColor = Color.FromArgb(94, 143, 51);
            button2.ForeColor = Color.FromArgb(0, 0, 0);
            button3.ForeColor = Color.FromArgb(0, 0, 0);
            button7.ForeColor = Color.FromArgb(0, 0, 0);
        }

        // Artikel Button
        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new ArtikelForm());
            button2.Image = Properties.Resources.Home__Off__28;
            button3.Image = Properties.Resources.Lightbulb_Filament__Off__28;
            button5.Image = Properties.Resources.Target_Arrow__Off__28;
            button7.Image = Properties.Resources.Feed__On__28;
            button7.ForeColor = Color.FromArgb(94, 143, 51);
            button2.ForeColor = Color.FromArgb(0, 0, 0);
            button3.ForeColor = Color.FromArgb(0, 0, 0);
            button5.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
