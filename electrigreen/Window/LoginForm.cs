using electrigreen.Core;
using electrigreen.Frame;
using electrigreen.Models;
using System.Diagnostics;
using System.Net.Http.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginPage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            try
            {
                AuthenticationMethod authen = new AuthenticationMethod();
                bool isAuthenticated = await authen.ValidateUserAsync(email, password);

                if (isAuthenticated)
                {
                    MessageBox.Show("Email and Password are Correct!");
                }
                else
                {
                    MessageBox.Show("Failed to Login, Email or Password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}
