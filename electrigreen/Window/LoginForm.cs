
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



        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private async void authButton1_Click(object sender, EventArgs e)
        {
            string email = authTextBox1.Text;
            string password = authTextBox2.Text;

            AuthenticationMethod authen = new AuthenticationMethod();

            if (!authen.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            try
            {
                bool isAuthenticated = await authen.ValidateUserAsync(email, password);
                
                if (isAuthenticated)
                {
                    User user = await authen.GetUserByEmailAsync(email);
                    this.Visible = false;
                    MainForm mainForm = new MainForm(user);
                    mainForm.Show();
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
