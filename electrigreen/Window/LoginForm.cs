
using electrigreen.Frame;
using electrigreen.Models;
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
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("http://localhost:5263");

                try
                {

                    var isAuthenticated = await AuthenticateWithAPI(textBox1.Text, textBox2.Text);

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
        public async Task<bool> AuthenticateWithAPI(string email, string password)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:5263");

                var loginUser = new LoginModel { Email = email, Password = password };

                HttpResponseMessage resMessage = await httpClient.PostAsJsonAsync("api/Register/login", loginUser);

                if (resMessage.IsSuccessStatusCode)
                {
                    return true;
                }
                else if (resMessage.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}