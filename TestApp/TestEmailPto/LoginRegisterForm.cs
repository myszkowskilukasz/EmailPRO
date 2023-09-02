using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestEmailPto.GeneralAPI;

namespace TestEmailPto
{
    public delegate void LoginHandler(object sender, string username);
    public partial class LoginRegisterForm : Form
    {
        public event LoginHandler OnLogin;
        private readonly GeneralServiceClient _application;
        public LoginRegisterForm()
        {
            _application = new GeneralServiceClient();
            InitializeComponent();
        }

        private async void loginRegisterControl_LoginPressed(object sender, EventArgs e)
        {
            var username = await _application.LoginAsync(loginRegisterControl.Username, loginRegisterControl.Password);
            if (username != "Username" && username != "Password")
            {
                OnLogin?.Invoke(this, username);
                Close();
            }
            else if (username == "Username")
            {
                loginRegisterControl.MessageColor = Color.Red;
                loginRegisterControl.MessageText = $"Failed to log in!! \nUsername - {loginRegisterControl.Username} " +
                    $"- doesn't exist in the system yet. Please register first.";
            }
            else if (username == "Password")
            {
                loginRegisterControl.MessageColor = Color.Red;
                loginRegisterControl.MessageText = $"Failed to log in!! \nThe given password is incorrect. Please try again.";
            }
            await Task.Delay(3000);
            loginRegisterControl.MessageText = string.Empty;
        }

        private async void loginRegisterControl_RegisterPressed(object sender, EventArgs e)
        {
            if (!await _application.RegisterAsync(loginRegisterControl.Username, loginRegisterControl.Password))
            {
                loginRegisterControl.MessageColor = Color.Red;
                loginRegisterControl.MessageText = $"Failed to register!! \nThe given username - {loginRegisterControl.Username} " +
                    $"- is already taken. Please think of another one.";
            }
            else
            {
                loginRegisterControl.MessageColor = Color.Green;
                loginRegisterControl.MessageText = $"Registration successful! " +
                    $"\nPlease log in using your new credentials, {loginRegisterControl.Username}.";
            }
            await Task.Delay(3000);
            loginRegisterControl.MessageText = string.Empty;
        }
    }
}
