namespace electrigreen.Window
{
    public partial class Artikel : Form
    {
        public Artikel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void ARTIKEL1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsiArtikel IA = new IsiArtikel();
            IA.SetArticle(1);
            IA.ShowDialog();
            this.Show(); 
        }

        private void ARTIKEL2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsiArtikel IA = new IsiArtikel();
            IA.SetArticle(2);
            IA.ShowDialog();
            this.Show(); 
        }

        private void ARTIKEL3_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsiArtikel IA = new IsiArtikel();
            IA.SetArticle(3);
            IA.ShowDialog();
            this.Show(); 
        }

        private void ARTIKEL4_Click(object sender, EventArgs e)
        {
            this.Hide();
            IsiArtikel IA = new IsiArtikel();
            IA.SetArticle(4);
            IA.ShowDialog();
            this.Show(); 
        }

        private void Back_Menu_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Do you want to Exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
